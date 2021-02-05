using System;
using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using TestCodeFirst.WorkWithCollection;
using TestCodeFirst.DataContext;
namespace TestCodeFirst.ViewModels
{
    [NotMapped]
    public class ДневнаяНормаVM : BaseClassOnChanged
    {
        private ДневнаяНормаНаУстановку currentNorm;
        private РежимРаботыУстановки selectedMode;
        private readonly CodeFirstContext cfc;
        private ObservableCollection<РежимРаботыАгрегата> operationMods;

        public ObservableCollection<РежимРаботыУстановки> ModePowersDevices { get; set; }
        public ObservableCollection<РежимРаботыАгрегата> OperationMods
        {
            get { return operationMods; }
            set
            {
                operationMods = value;
                OnChangerd(nameof(OperationMods));
            }
        }   
        public ObservableCollection<СиловойАгрегатВУстановке> PowerDevices { get; set; }

        public РежимРаботыУстановки SelectedMode
        {
            get { return selectedMode; }
            set
            {
                selectedMode = value;

                // И я снова исправил эту функцию :)
                currentNorm.РежимРаботыУстановки = value;
                cfc.SaveChanges();
                OnChangerd(nameof(SelectedMode));                
                UpdateOperationMods(currentNorm.Норма);
            }
        }

        private void UpdateOperationMods(decimal норма)
        {
            CodeFirstContext cfc = new CodeFirstContext();

            // Отбор записей в таблице РежимРаботыАгрегатаSet, где режим работы установки,
            // соответсвует режиму работы силового агрегата и коды установок совпадают.
            cfc.РежимРаботыАгрегатаSet
                .Where(w => w.РежимРаботы == selectedMode.РежимРаботы
                    && w.СиловойАгрегатВУстройстве.ТехнологическаяУстановка.УстройствоId
                        == selectedMode.ТехнологическаяУстановка.УстройствоId)
                .Load();

            OperationMods = WorkCollection.GetРежимРаботы<РежимРаботыАгрегата>(cfc);
            
            try
            {
                OperationMods.ToList().ForEach(x => x.РасчитанноеПотребление =
                        Math.Round(((норма / selectedMode.Производительность) * x.Потребление), 2));
            }
            catch (DivideByZeroException)
            {
                OperationMods.ToList().ForEach(x => x.РасчитанноеПотребление = 0);
            }
        }

        public ДневнаяНормаVM(ДневнаяНормаНаУстановку дневнаяНормаНаУстановку)
        {
            // Инициализация контекста данных.
            cfc = new CodeFirstContext();

            // Выбрать текущую запись о дневной норме, для обновления поля - режим работы, в свойстве SelectedMode.
            cfc.ДневнаяНормаНаУстановкуSet
                .Where(w => w.Id == дневнаяНормаНаУстановку.Id)
                .Load();
            currentNorm = cfc.ДневнаяНормаНаУстановкуSet.Local.FirstOrDefault();

            // Заполнение combobox, данными из таблицы РежимРаботыУстановкиSet.
            cfc.РежимРаботыУстановкиSet
                .Where(w => w.ТехнологическаяУстановка.УстройствоId
                    == дневнаяНормаНаУстановку.ТехнологическаяУстановка.УстройствоId)
                .Load();
            ModePowersDevices = WorkCollection.GetРежимыРаботыУстановки<РежимРаботыУстановки>(cfc);

            // Усановка combobox в выбранное состояние.
            selectedMode = currentNorm.РежимРаботыУстановки;

            // Обновление и заполнение DataGrid.ы
            if (selectedMode != null)
            {
                UpdateOperationMods(currentNorm.Норма);  
            }           
        }
    }
}
