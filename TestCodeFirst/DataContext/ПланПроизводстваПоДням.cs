namespace TestCodeFirst.DataContext
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.ObjectModel;

    public partial class ПланПроизводстваПоДням
    {
        public ПланПроизводстваПоДням() {}

        public ПланПроизводстваПоДням(int day)
        {
            this.КаледнарныйДень = day;
            this.ДневнаяНормаНаУстановку = new ObservableCollection<ДневнаяНормаНаУстановку>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int КаледнарныйДень { get; set; }

        public virtual ПланПроизводстваПоМесяцам ПланПроизводстваПоМесяцам { get; set; }

        public virtual ObservableCollection<ДневнаяНормаНаУстановку> ДневнаяНормаНаУстановку { get; set; }
    }
}
