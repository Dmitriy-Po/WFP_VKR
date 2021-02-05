using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Collections.Specialized;
using TestCodeFirst.WorkWithCollection;
using TestCodeFirst.DataContext;
using TestCodeFirst.Commands;

namespace TestCodeFirst.ViewModels
{
    [NotMapped]
    public class РежимРаботыVM : BaseClassOnChanged
    {
        private РежимРаботыАгрегата режимРаботы;
        private CodeFirstContext cfc;
        private СиловойАгрегатВУстановке currentPowerDev;
        private СправочникРесурсов selectedRes;
        private УстановкаРежимРесурс currentустройствоРежимРесурс;
        private SaveCommand saveChanges;
        private ТипЕдиницИзмерения selectedТипЕдиниц;

        public SaveCommand SaveChanges => saveChanges ?? (saveChanges = new SaveCommand(cfc));
        public ObservableCollection<СправочникРесурсов> ListResource { get; set; }

        public ТипЕдиницИзмерения SelectedТипЕдиниц
        {
            get { return selectedТипЕдиниц; }
            set
            {
                selectedТипЕдиниц = value;
                currentPowerDev.ТипЕдиницИзмерения = value;
                OperatingModePD
                    .ToList()
                    .ForEach(x => x.ТипЕдиниц = value);
                cfc.SaveChanges();
                OnChangerd(nameof(SelectedТипЕдиниц));
            }
        }

        public СправочникРесурсов SelectedRes
        {
            get { return selectedRes; }
            set
            {
                selectedRes = value;

                // Для заметки: потрачено 2 дня, на исправление ошибки с обновлением внешнего ключа.
                // я поправлю, обещаю                

                //var nodifItem = currentPowerDev.УстановкаРежимРесурс
                //    .Where(w => w.СиловойАгрегатВУстановке == currentустройствоРежимРесурс.СиловойАгрегатВУстановке
                //        && w.СправочникРесурсов == currentустройствоРежимРесурс.СправочникРесурсов)
                //    .FirstOrDefault();

                //УстановкаРежимРесурс установкаРежимРесурс = new УстановкаРежимРесурс(
                //    currentустройствоРежимРесурс.СиловойАгрегатВУстановкеId, 
                //    currentустройствоРежимРесурс.РесурсId);

                //установкаРежимРесурс.СправочникРесурсов = currentустройствоРежимРесурс.СправочникРесурсов;
                //установкаРежимРесурс.РесурсId = value.Id;
                //currentустройствоРежимРесурс.РесурсId = value.Id;
                //cfc.СиловойАгрегатВУстройствеSet.Attach(currentPowerDev);
                //cfc.Entry(currentPowerDev).State = EntityState.Modified;

                //var ttt = currentPowerDev.УстановкаРежимРесурс.FirstOrDefault();
                //ttt.СправочникРесурсов.Id = value.Id;
                //currentустройствоРежимРесурс.РесурсId = value.Id;

                //cfc.УстройствоРежимРесурсSet.Attach(ttt);
                //cfc.Entry(ttt).State = EntityState.Modified;                
                //cfc.Entry(ttt).Property(o => o.СправочникРесурсов.Id).IsModified = true;
                currentустройствоРежимРесурс.СправочникРесурсовFK = value.Id;
                OperatingModePD                    
                    .ToList()
                    .ForEach(x => x.НаименованиеРесурса = value.НаименованиеРесурса);

                cfc.SaveChanges();
                OnChangerd(nameof(SelectedRes));
            }
        }

        public РежимРаботыАгрегата SelectedPowerDevice
        {
            get { return режимРаботы; }
            set
            {
                режимРаботы = value;
                cfc.SaveChanges();
                OnChangerd(nameof(SelectedPowerDevice));
            }
        }
        public ObservableCollection<РежимРаботыАгрегата> OperatingModePD { get; set; }

        public РежимРаботыVM(УстановкаРежимРесурс устройствоРежимРесурс)
        {
            OperatingModePD = new ObservableCollection<РежимРаботыАгрегата>();
            cfc = new CodeFirstContext();

            //cfc.СправочникРесурсовSet.Load();
            //cfc.УстройствоРежимРесурсSet
            //    .Where(w => w.УстановкаId == устройствоРежимРесурс.УстановкаId
            //        && w.РесурсId == устройствоРежимРесурс.РесурсId)
            //    .Load();

            //currentустройствоРежимРесурс = cfc.УстройствоРежимРесурсSet
            //    .Local
            //    .Where(w => w.РесурсId == устройствоРежимРесурс.РесурсId
            //        && w.УстановкаId == устройствоРежимРесурс.УстановкаId
            //        && w.РежимРаботыУстановкиId == устройствоРежимРесурс.РежимРаботыУстановкиId)
            //    .FirstOrDefault();

            ListResource = WorkCollection.GetСправочникРесурсов<СправочникРесурсов>(cfc);

            //selectedRes = cfc
            //    .УстройствоРежимРесурсSet
            //    .Local
            //    .Where(w => w.УстановкаId == устройствоРежимРесурс.УстановкаId
            //        && w.РесурсId == устройствоРежимРесурс.РесурсId)
            //    .Select(s => s.СправочникРесурсов)
            //    .FirstOrDefault();

            var ContextCollection = cfc.УстройствоРежимРесурсSet.Local;

            //selectedRes = ContextCollection
            //        .Where(w => w.УстановкаId == устройствоРежимРесурс.УстановкаId
            //            && w.РесурсId == устройствоРежимРесурс.РесурсId)
            //        .Select(s => s.СправочникРесурсов)
            //        .FirstOrDefault();

            //TODO 2021-01-10: Вынести в отдельный класс по заполнению коллекций.
            //foreach (УстановкаРежимРесурс item in ContextCollection)
            //{
            //    OperatingModePD.Add(item.РежимРаботыСиловогоАгретата);
            //}

            //currentустройствоРежимРесурс = ContextCollection
            //        .Where(w => w.РесурсId == устройствоРежимРесурс.РесурсId
            //            && w.УстановкаId == устройствоРежимРесурс.УстановкаId
            //            && w.РежимРаботыАгрегатаId == устройствоРежимРесурс.РежимРаботыАгрегатаId)
            //        .FirstOrDefault();
        }

        public РежимРаботыVM(СиловойАгрегатВУстановке агрегатВУстройстве)
        {
            cfc = new CodeFirstContext();
            cfc.УстройствоРежимРесурсSet.Load();
            cfc.СправочникРесурсовSet.Load();
            cfc.РежимРаботыАгрегатаSet.Load();
            cfc.СиловойАгрегатВУстройствеSet.Load();
            OperatingModePD = new ObservableCollection<РежимРаботыАгрегата>(); 
            
            var contextCollectionOperationModes = cfc
                .РежимРаботыАгрегатаSet
                .Local
                .Where(w => w.СиловойАгрегатВУстройстве
                    .Id.Equals(агрегатВУстройстве.Id));

            // Получение внешнего ключа из текущего контекста.
            currentPowerDev = cfc
                .СиловойАгрегатВУстройствеSet
                .Local
                .Where(w => w.Id == агрегатВУстройстве.Id)
                .FirstOrDefault();

            // Установка значения combobox в ранее выбранное состояние.
            selectedТипЕдиниц = currentPowerDev.ТипЕдиницИзмерения;

            // Получение выбранного ресурса.
            //selectedRes = currentPowerDev.УстановкаРежимРесурс
            //    .Where(w => w.СиловойАгрегатВУстановке.Id == currentPowerDev.Id)
            //    .Select(s => s.СправочникРесурсов)
            //    .FirstOrDefault();

            int idrecord = cfc.УстройствоРежимРесурсSet
                .Local
                .Where(w => w.СиловойАгрегатВУстановкеFK == currentPowerDev.Id)
                .FirstOrDefault().СправочникРесурсовFK;

            selectedRes = cfc.СправочникРесурсовSet.Local.Where(w => w.Id == idrecord).FirstOrDefault();

            currentустройствоРежимРесурс = cfc
                .УстройствоРежимРесурсSet
                .Local
                .Where(w => w.СиловойАгрегатВУстановкеFK == currentPowerDev.Id
                    && w.СправочникРесурсовFK == selectedRes.Id)
                .FirstOrDefault();

            //if (collection.FirstOrDefault() != null)
            //{
            //    currentPowerDev = collection
            //            .FirstOrDefault()
            //            .СиловойАгрегатВУстройстве; 
            //}

            //TODO 2021-01-10: Вынести в отдельный класс по заполнению коллекций.
            foreach (РежимРаботыАгрегата item in contextCollectionOperationModes)
            {
                OperatingModePD.Add(item);
            }

            ListResource = WorkCollection.GetСправочникРесурсов<СправочникРесурсов>(cfc);

            OperatingModePD.CollectionChanged += OperatingModePD_CollectionChanged;
        }

        private void OperatingModePD_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //Добавление внешнего ключа в поле - СиловойАгрегатВУстройстве.
            (sender as ObservableCollection<РежимРаботыАгрегата>)
                .Where(w => w.СиловойАгрегатВУстройстве == null)
                .ToList()
                .ForEach(x => 
                    {
                        x.СиловойАгрегатВУстройстве = currentPowerDev;
                        x.НаименованиеРесурса = selectedRes.НаименованиеРесурса ?? "Наименование отсувсвует";
                        x.ТипЕдиниц = currentPowerDev.ТипЕдиницИзмерения;                        
                    });

            WorkCollection.ItemCollectionChanged<РежимРаботыАгрегата>(cfc, e);
        }
    }
}
