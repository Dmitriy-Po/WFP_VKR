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
    public class СправочникРесурсовVM : BaseClassOnChanged
    {
        private readonly CodeFirstContext cfc;
        private СправочникРесурсов currentSelectedResource;

        public ObservableCollection<СправочникРесурсов> ListResource { get; set; }

        public СправочникРесурсов CurrentSelectedResource
        {
            get { return currentSelectedResource; }
            set
            {
                currentSelectedResource = value;
                cfc.SaveChanges();
                OnChangerd(nameof(CurrentSelectedResource));
            }
        }

        public СправочникРесурсовVM()
        {
            cfc = new CodeFirstContext();

            cfc.СправочникРесурсовSet.Load();

            ListResource = WorkCollection.GetСправочникРесурсов<СправочникРесурсов>(cfc);
            ListResource.CollectionChanged += ListResource_CollectionChanged;
        }

        private void ListResource_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            WorkCollection.ItemCollectionChanged<СправочникРесурсов>(cfc, e);
        }
    }
}
