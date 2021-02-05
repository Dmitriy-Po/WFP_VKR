namespace TestCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TestCodeFirst.DataContext;

    public partial class СиловойАгрегатВУстановке
    {
        public СиловойАгрегатВУстановке() {}
        public СиловойАгрегатВУстановке(string наименование)
        {
            Наименование = наименование;
            //ТипЭнергии = энергия;
            РежимРаботыАгрегата = new ObservableCollection<РежимРаботыАгрегата>();
        }
    
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Наименование { get; set; }
        public ТипЕдиницИзмерения ТипЕдиницИзмерения { get; set; }

        //public virtual СправочникРесурсов СправочникРесурсов { get; set; }

        //public virtual ObservableCollection<УстановкаРежимРесурс> УстановкаРежимРесурс { get; set; }
        public virtual ТехнологическаяУстановка ТехнологическаяУстановка { get; set; }
        public virtual ObservableCollection<РежимРаботыАгрегата> РежимРаботыАгрегата { get; set; }
    }
}
