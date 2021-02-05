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
using TestCodeFirst.WorkWithCollection;

namespace TestCodeFirst.ViewModels
{
    [NotMapped]
    public class УстройствоVM : BaseClassOnChanged
    {
        private ТехнологическаяУстановка selectedDevice;
        private CodeFirstContext cfc;

        public ObservableCollection<ТехнологическаяУстановка> Devices { get; set; }
        public ТехнологическаяУстановка SelectedDevice 
        {
            get { return selectedDevice; } 
            set
            {
                selectedDevice = value;
                cfc.SaveChanges();
                OnChangerd(nameof(SelectedDevice));
            }
        }       

        public УстройствоVM()
        {
            cfc = new CodeFirstContext();
            cfc.УстановкаSet.Load();

            Devices = WorkCollection.GetТехнологическоеУстройство<ТехнологическаяУстановка>(cfc);
            Devices.CollectionChanged += Devices_CollectionChanged;
        }

        private void Devices_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            WorkCollection.ItemCollectionChanged<ТехнологическаяУстановка>(cfc, e);            
        }
    }
}
