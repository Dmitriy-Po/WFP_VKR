using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCodeFirst.Commands;
using TestCodeFirst.DataContext;
using TestCodeFirst.WorkWithCollection;
namespace TestCodeFirst.ViewModels
{
    [NotMapped]
    public class РежимРаботыУстановкиVM : BaseClassOnChanged
    {
        private readonly CodeFirstContext cfc;
        private ТехнологическаяУстановка currentDev;
        private РежимРаботыУстановки selectedOperationMode;
        private SaveCommand saveChanges;


        public SaveCommand SaveChanges => saveChanges ?? (saveChanges = new SaveCommand(cfc));

        public ObservableCollection<РежимРаботыУстановки> ModeOperationDevice { get; set; }

        public РежимРаботыУстановки SelectedOperationMode
        {
            get { return selectedOperationMode; }
            set
            {
                selectedOperationMode = value;
                cfc.SaveChanges();
                OnChangerd(nameof(SelectedOperationMode));
            }
        }

        public РежимРаботыУстановкиVM(ТехнологическаяУстановка технологическаяУстановка)
        {
            cfc = new CodeFirstContext();
            cfc.РежимРаботыУстановкиSet
                .Where(w => w.ТехнологическаяУстановка.УстройствоId == технологическаяУстановка.УстройствоId)
                .Load();

            cfc.УстановкаSet
                .Where(w => w.УстройствоId == технологическаяУстановка.УстройствоId)
                .Load();

            currentDev = cfc.УстановкаSet.Local.FirstOrDefault() as ТехнологическаяУстановка;

            ModeOperationDevice = WorkCollection.GetРежимыРаботыУстановки<РежимРаботыУстановки>(cfc);
            ModeOperationDevice.CollectionChanged += ModeOperationDevice_CollectionChanged;
        }

        private void ModeOperationDevice_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //Добавление внешнего ключа в поле - СиловойАгрегатВУстройстве.
            (sender as ObservableCollection<РежимРаботыУстановки>)
                .Where(w => w.ТехнологическаяУстановка == null)
                .ToList()
                .ForEach(x => x.ТехнологическаяУстановка = currentDev);

            WorkCollection.ItemCollectionChanged<РежимРаботыУстановки>(cfc, e);
        }
    }
}
