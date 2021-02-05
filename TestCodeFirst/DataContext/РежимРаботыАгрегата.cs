namespace TestCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TestCodeFirst.DataContext;

    public partial class РежимРаботыАгрегата
    {
        public РежимРаботыАгрегата() {}
        public РежимРаботыАгрегата(
            decimal потребление,
            РежимРаботы режимРаботы)
        {
            Потребление = потребление;
            //Производительность = производительность;
            РежимРаботы = режимРаботы;
        }

       [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int Id { get; set; }
       public РежимРаботы РежимРаботы { get; set; }
       public decimal Потребление { get; set; }
       //public decimal Производительность { get; set; }
       public virtual СиловойАгрегатВУстановке СиловойАгрегатВУстройстве { get; set; }
       //public virtual ObservableCollection<УстановкаРежимРесурс> УстройствоРежимРесурс { get; set; }
       
       public string НаименованиеРесурса { get; set; }

        public ТипЕдиницИзмерения ТипЕдиниц { get; set; }
       [NotMapped]
       public decimal РасчитанноеПотребление { get; set; }
    }
}
