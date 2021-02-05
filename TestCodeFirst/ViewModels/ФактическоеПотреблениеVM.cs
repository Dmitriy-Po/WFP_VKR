using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using TestCodeFirst.WorkWithCollection;
using TestCodeFirst.DataContext;

namespace TestCodeFirst.ViewModels
{
    [NotMapped]
    public class ФактическоеПотреблениеVM : BaseClassOnChanged
    {
        private CodeFirstContext cfc;
        private ПланНормативныйТехнологический currentPlan;
        private ТехнологическаяУстановка selectedDev;
        private СиловойАгрегатВУстановке selectedPowerDev;
        private РежимРаботыАгрегата selectedOperationMode;
        private ФактическоеПотребление selectedActualConsumption;

        public ObservableCollection<ФактическоеПотребление> ActualConsumption { get; set; }

        public ObservableCollection<ТехнологическаяУстановка> Devices { get; set; }

        public ФактическоеПотребление SelectedActualConsumption
        {
            get { return selectedActualConsumption; }
            set
            {
                selectedActualConsumption = value;
                cfc.SaveChanges();
                OnChangerd(nameof(SelectedActualConsumption));
            }
        }

        public ТехнологическаяУстановка SelectedDev
        {
            get { return selectedDev; }
            set
            {
                if (value != null && currentPlan != null)
                {
                    selectedDev = value;
                    currentPlan.УстройствоFK = value.УстройствоId;
                    cfc.SaveChanges();
                    OnChangerd(nameof(SelectedDev)); 
                }
            }
        }

        public СиловойАгрегатВУстановке SelectedPowerDev
        {
            get { return selectedPowerDev; }
            set
            {
                if (value != null)
                {
                    selectedPowerDev = value;
                    currentPlan.ТипЭнергииId = value.Id;
                    cfc.SaveChanges();
                    OnChangerd(nameof(SelectedPowerDev));
                }                
            }
        }

        public РежимРаботыАгрегата SelectedOperationMode
        {
            get { return selectedOperationMode; }
            set
            {
                if (value != null)
                {
                    selectedOperationMode = value;
                    currentPlan.РежимРаботыId = value.Id;
                    cfc.SaveChanges();
                    OnChangerd(nameof(SelectedOperationMode)); 
                }
            }
        }

        public ПланНормативныйТехнологический CurrentPlan
        {
            get { return currentPlan; }
            set
            {
                currentPlan = value;
                OnChangerd(nameof(CurrentPlan));
            }
        }

        public ФактическоеПотреблениеVM(ПланНормативныйТехнологический планНормативный)
        {
            cfc = new CodeFirstContext();
            ActualConsumption = new ObservableCollection<ФактическоеПотребление>();

            cfc.ФактическоеПотреблениеSet
                .Where(w => w.ПланНормативныйТехнологический.Id == планНормативный.Id)
                .Load();
            var contextCollection = cfc.ФактическоеПотреблениеSet.Local;

            foreach (ФактическоеПотребление item in contextCollection)
            {
                ActualConsumption.Add(item);
            }

            //ActualConsumption = WorkCollection.GetФактическоеПотребление<ФактическоеПотребление>(cfc);
            cfc.УстановкаSet.Load();
            Devices = WorkCollection.GetТехнологическоеУстройство<ТехнологическаяУстановка>(cfc);

            UpLoadComboBoxes(планНормативный);
            //if (ActualConsumption.Count > 0)
            //{
            //    UpLoadComboBoxes(планНормативный);
            //}

            ActualConsumption.CollectionChanged += ActualConsumption_CollectionChanged;            
        }

        private void UpLoadComboBoxes(ПланНормативныйТехнологический план)
        {
            
            var devices = cfc.УстановкаSet.Local;

            cfc.СправочникSet.Load();
            var collection = cfc.СправочникSet
                .Local
                .Where(w => w.Id == план.Id)
                .Cast<ПланНормативныйТехнологический>()
                .FirstOrDefault();

            currentPlan = collection;

            selectedDev = (ТехнологическаяУстановка)devices
                .Where(w => w.УстройствоId == currentPlan.УстройствоFK)
                ?.FirstOrDefault();

            if (selectedDev != null)
            {
                selectedPowerDev = selectedDev
                    .СиловойАгрегатВУстройстве
                    .Where(w => w.ТехнологическаяУстановка.УстройствоId == selectedDev.УстройствоId
                        && w.Id == currentPlan.ТипЭнергииId)
                    ?.FirstOrDefault();

                if (selectedPowerDev != null)
                {
                    selectedOperationMode = selectedPowerDev
                        .РежимРаботыАгрегата
                        .Where(w => w.СиловойАгрегатВУстройстве.Id == selectedPowerDev.Id
                            && w.Id == currentPlan.РежимРаботыId)
                        ?.FirstOrDefault(); 
                } 
            }
        }

        private void ActualConsumption_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            (sender as ObservableCollection<ФактическоеПотребление>)
                .Where(w => w.ПланНормативныйТехнологический == null)
                .ToList()
                .ForEach(x => x.ПланНормативныйТехнологический = currentPlan);

            WorkCollection.ItemCollectionChanged<ФактическоеПотребление>(cfc, e);
        }
    }
}
