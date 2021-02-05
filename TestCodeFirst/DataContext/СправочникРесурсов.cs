using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestCodeFirst.DataContext
{
    public class СправочникРесурсов
    {
        public СправочникРесурсов() { }

        public СправочникРесурсов(string наименованиеРесурса)
        {
            НаименованиеРесурса = наименованиеРесурса;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        public string НаименованиеРесурса { get; set; }


        //public virtual ObservableCollection<УстановкаРежимРесурс> УстройствоРежимРесурс { get; set; }

        //public virtual ObservableCollection<ТехнологическоеУстройство> Установки { get; set; }
    }
}
