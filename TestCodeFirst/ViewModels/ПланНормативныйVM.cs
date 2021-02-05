using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCodeFirst.WorkWithCollection;

namespace TestCodeFirst.ViewModels
{
    [NotMapped]
    public class ПланНормативныйVM : BaseClassOnChanged
    {
        private ПланНормативныйТехнологический selectedPlan;
        private CodeFirstContext cfc;

        public ПланНормативныйТехнологический SelectedPlan
        {
            get { return selectedPlan; }
            set
            {
                selectedPlan = value;
                cfc.SaveChanges();
                OnChangerd(nameof(SelectedPlan));
            }
        }
        public ObservableCollection<ПланНормативныйТехнологический> Plans { get; set; }        

        public ПланНормативныйVM()
        {
            cfc = new CodeFirstContext();
            cfc.СправочникSet.Load();
            Plans = WorkCollection.GetПланНормативныйТехнологический<ПланНормативныйТехнологический>(cfc);
            Plans.CollectionChanged += Plans_CollectionChanged;
        }

        private void Plans_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            WorkCollection.ItemCollectionChanged<ПланНормативныйТехнологический>(cfc, e);
        }
    }
}
