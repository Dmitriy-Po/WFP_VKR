using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TestCodeFirst.DataContext
{
    public class РежимРаботыУстановки
    {
        public РежимРаботыУстановки()
        {

        }

        public РежимРаботыУстановки(РежимРаботы режимРаботы, decimal производительность)
        {
            РежимРаботы = режимРаботы;
            Производительность = производительность;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public РежимРаботы РежимРаботы { get; set; }
        public decimal Производительность { get; set; }
        public virtual ТехнологическаяУстановка ТехнологическаяУстановка { get; set; }
    }
}
