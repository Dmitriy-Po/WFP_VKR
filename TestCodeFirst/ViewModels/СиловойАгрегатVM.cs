using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Collections.Specialized;
using TestCodeFirst.DataContext;
using TestCodeFirst.Commands;
using TestCodeFirst.WorkWithCollection;

namespace TestCodeFirst.ViewModels
{
    [NotMapped]
    public class СиловойАгрегатVM : BaseClassOnChanged
    {
        private SaveCommand saveCommand;
        private СиловойАгрегатВУстановке selectedPowerDevice;
        private readonly CodeFirstContext cfc;
        private readonly ТехнологическаяУстановка currentDevice;

        public SaveCommand Save => saveCommand ?? (saveCommand = new SaveCommand(cfc));
        public СиловойАгрегатВУстановке SelectedPowerDevice
        {
            get { return selectedPowerDevice; }
            set
            {
                selectedPowerDevice = value;
                cfc.SaveChanges();
                OnChangerd(nameof(SelectedPowerDevice));
            }
        }
        public ObservableCollection<СиловойАгрегатВУстановке> PowerDevices { get; set; }
        private ObservableCollection<УстановкаРежимРесурс> установкаРежимРесурсSets { get; set; }

        public СиловойАгрегатVM(ТехнологическаяУстановка технологическоеУстройство)
        {
            cfc = new CodeFirstContext();
            cfc.СиловойАгрегатВУстройствеSet.Load();
            cfc.УстановкаSet.Load();
            cfc.УстройствоРежимРесурсSet.Load();

            PowerDevices = new ObservableCollection<СиловойАгрегатВУстановке>();
            установкаРежимРесурсSets = new ObservableCollection<УстановкаРежимРесурс>();

            var contextCollection = cfc
                .СиловойАгрегатВУстройствеSet
                .Where(w => w.ТехнологическаяУстановка
                    .УстройствоId.Equals(технологическоеУстройство.УстройствоId));

            // Получение внешнего ключа из текущего контекста.
            currentDevice = (ТехнологическаяУстановка)cfc
                .УстановкаSet
                .Local
                .Where(w => w.УстройствоId == технологическоеУстройство.УстройствоId)
                .FirstOrDefault();

            //TODO 2021-01-10: Вынести в отдельный класс по заполнению коллекций.
            foreach (СиловойАгрегатВУстановке item in contextCollection)
            {
                PowerDevices.Add(item);
            }

            установкаРежимРесурсSets = WorkCollection.GetУстановкаРежимРесурс<УстановкаРежимРесурс>(cfc);

            PowerDevices.CollectionChanged += PowerDevices_CollectionChanged;            
        }

        private void PowerDevices_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            // Данная выборка добавляет внешний ключ к полю ТехнологическоеУстройство, из текущего контекса,
            // так как при добавлении строки в DataGrid это поле пустое.

            // Существовала ошибка с пустой ссылкой поля currentDevice, когда добавленная строка 
            // силового агрегата не имела внешнего ключа таблицы УстройствоSet.
            (sender as ObservableCollection<СиловойАгрегатВУстановке>)
                .Where(w => w.ТехнологическаяУстановка == null)
                .ToList()
                .ForEach(x => x.ТехнологическаяУстановка = currentDevice);

            WorkCollection.ItemCollectionChanged<СиловойАгрегатВУстановке>(cfc, e);


            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                var coll = e.NewItems;
                foreach (СиловойАгрегатВУстановке item in coll)
                {
                    cfc.УстройствоРежимРесурсSet.Add(new УстановкаРежимРесурс(item.Id, 1));
                }
                cfc.SaveChanges(); 
            }
        }
    }
}
