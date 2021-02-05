namespace TestCodeFirst
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.ObjectModel;
    using TestCodeFirst.DataContext;

    public partial class ПланПроизводстваПоМесяцам
    {
        public ПланПроизводстваПоМесяцам() { }
        public ПланПроизводстваПоМесяцам(
            int year, 
            int mount, 
            string nameMount)
        {
            this.КалендарныйГод = year;
            this.НомерМесяца = mount;
            this.НаименованиеМесяца = nameMount;
            this.ПланПроизводстваПоДням = new ObservableCollection<ПланПроизводстваПоДням>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int КалендарныйГод { get; set; }

        [StringLength(50)]
        public string НаименованиеМесяца { get; set; }

        public int НомерМесяца { get; set; }

        public virtual ObservableCollection<ПланПроизводстваПоДням> ПланПроизводстваПоДням { get; set; }
    }
}
