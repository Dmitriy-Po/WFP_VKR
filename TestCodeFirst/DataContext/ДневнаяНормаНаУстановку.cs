using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;
namespace TestCodeFirst.DataContext
{
    public partial class ДневнаяНормаНаУстановку
    {
        public ДневнаяНормаНаУстановку() { }

        public ДневнаяНормаНаУстановку(decimal norm)
        {
            this.Норма = norm;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public decimal Норма { get; set; }

        //public virtual УстановкаРежимРесурс УстройствоРежимРесурс { get; set; }

        public РежимРаботыУстановки РежимРаботыУстановки  { get; set; }

        public virtual ТехнологическаяУстановка ТехнологическаяУстановка { get; set; }

        public virtual ПланПроизводстваПоДням ПланПроизводстваПоДням { get; set; }

        //public virtual ObservableCollection<ТехнологическоеУстройство> ТехнологическиеУстановки { get; set; }
    }
}
