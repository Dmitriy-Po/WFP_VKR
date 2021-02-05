using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TestCodeFirst.DataContext;
using TestCodeFirst.WorkWithCollection;

namespace TestCodeFirst.ViewModels
{
    [NotMapped]
    public class ПланПоМесяцамVM : BaseClassOnChanged
    {
        private CodeFirstContext cfc;
        private ПланПроизводстваПоМесяцам selectedMountPlan;
        private ПланПроизводстваПоДням selectedDayPlan;
        private ДневнаяНормаНаУстановку selectedNorm;


        public ObservableCollection<ТехнологическаяУстановка> Devices { get; set; }
        public ObservableCollection<ПланПроизводстваПоМесяцам> планПроизводстваПоМесяцамs { get; set; }

        public ДневнаяНормаНаУстановку SelectedNorm
        {
            get { return selectedNorm; }
            set
            {
                selectedNorm = value;
                cfc.SaveChanges();
                OnChangerd(nameof(SelectedNorm));
            }
        }

        public ПланПроизводстваПоДням SelectedDayPlan
        {
            get { return selectedDayPlan; }
            set
            {
                selectedDayPlan = value;
                cfc.SaveChanges();
                OnChangerd(nameof(SelectedDayPlan));
            }
        }

        public ПланПроизводстваПоМесяцам SelectedMountPlan
        {
            get { return selectedMountPlan; }
            set
            {
                selectedMountPlan = value;
                cfc.SaveChanges();
                OnChangerd(nameof(SelectedMountPlan));
            }
        }

        public ПланПоМесяцамVM()
        {
            cfc = new CodeFirstContext();
            cfc.ПланПроизводстваПоМесяцамSet.Load();

            планПроизводстваПоМесяцамs = WorkCollection.GetПланПоМесяцам<ПланПроизводстваПоМесяцам>(cfc);
            планПроизводстваПоМесяцамs.CollectionChanged += ПланПроизводстваПоМесяцамs_CollectionChanged;
        }
        
        private void ПланПроизводстваПоМесяцамs_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                        cfc.ПланПроизводстваПоМесяцамSet.AddRange(GetNewItems(e));
                    break;
                case NotifyCollectionChangedAction.Remove:
                        cfc.ПланПроизводстваПоМесяцамSet.RemoveRange(e.OldItems.Cast<ПланПроизводстваПоМесяцам>());
                    break;                
            }

            cfc.SaveChanges();
        }

        private IEnumerable<ПланПроизводстваПоМесяцам> GetNewItems(NotifyCollectionChangedEventArgs e)
        {
            IEnumerable<ПланПроизводстваПоМесяцам> newItems = e.NewItems.Cast<ПланПроизводстваПоМесяцам>();
                        
            int numberofMounth = GetNumberOfLastMount();

            foreach (ПланПроизводстваПоМесяцам item in newItems)
            {
                item.КалендарныйГод = DateTime.Now.Year;
                item.НаименованиеМесяца = GetNameOfLastMounth(numberofMounth);
                // Добавить единицу, так как создаём запись на новый месяц.
                item.НомерМесяца = ++numberofMounth;
                item.ПланПроизводстваПоДням = GetDaysOfMount();
            }

            return newItems;
        }

        /// <summary>
        /// Функция возвращает номер последнего месяца, запись о котором присутсвует в таблице, за текущий год.
        /// </summary>
        private int GetNumberOfLastMount()
        {
            int numberOfMounth = cfc
                .ПланПроизводстваПоМесяцамSet
                .Local
                .Where(w => w.КалендарныйГод == DateTime.Now.Year)
                .OrderByDescending(o => o.НомерМесяца)
                .Select(s => s.НомерМесяца)
                .FirstOrDefault();

            return numberOfMounth;
        }

        /// <summary>
        /// Функция возвращает имя последнего месяца, запись о котором присутсвует в таблице, за текущий год.
        /// </summary>
        /// <returns></returns>
        private string GetNameOfLastMounth(int numberOfMount)
        {
            //TODO 2021-02-02: Сделать проверку по году, при переполнении месяцев
            return cfc
                .ПланПроизводстваПоМесяцамSet
                .Local
                .Where(w => w.НомерМесяца == numberOfMount
                    && w.КалендарныйГод == DateTime.Now.Year)
                .Select(s => s.НаименованиеМесяца)
                .FirstOrDefault() == null
                    ? "Январь" 
                    : DateTime
                        .Parse($"{DateTime.Now.Year}-{++numberOfMount}-01")
                        .ToString("MMMM", new CultureInfo("ru-RU"));
        }

        private ObservableCollection<ПланПроизводстваПоДням> GetDaysOfMount()
        {
            var list = new ObservableCollection<ПланПроизводстваПоДням>();
            int numberOfMount = GetNumberOfLastMount();
            int countDayOfMount = DateTime.DaysInMonth(DateTime.Now.Year, ++numberOfMount);

            for (int i = 1; i <= countDayOfMount; i++)
            {
                ПланПроизводстваПоДням planOfDay = new ПланПроизводстваПоДням();
                planOfDay.КаледнарныйДень = i;
                planOfDay.ДневнаяНормаНаУстановку = GetNormOfDays();
                list.Add(planOfDay);
            }

            return list;
        }

        /// <summary>
        /// Функция возвращает список дневных норм, по колличеству равных количеству установок.
        /// </summary>
        /// <returns>Коллекция дневных норм по установкам.</returns>
        private ObservableCollection<ДневнаяНормаНаУстановку> GetNormOfDays()
        {
            cfc.УстановкаSet.Load();
            var devices = cfc
                .УстановкаSet
                .Local
                .Cast<ТехнологическаяУстановка>();

            var dayNorms = new ObservableCollection<ДневнаяНормаНаУстановку>();

            foreach (var device in devices)
            {
                //Задаются значения по умолчанию.
                ДневнаяНормаНаУстановку day = new ДневнаяНормаНаУстановку();
                day.Норма = 0;
                day.ТехнологическаяУстановка = device;
                day.РежимРаботыУстановки = device.РежимыРаботыУстановки.FirstOrDefault();
                dayNorms.Add(day);
            }

            return dayNorms;
        }
    }
}
