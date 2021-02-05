using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;

namespace TestCodeFirst.DataContext
{
    public partial class УстановкаРежимРесурс
    {
        public УстановкаРежимРесурс()
        {

        }
        public УстановкаРежимРесурс(int ID_записиСиловогоАгрегата, int ID_записиРесурса)
        {
            this.СиловойАгрегатВУстановкеFK = ID_записиСиловогоАгрегата;
            this.СправочникРесурсовFK = ID_записиРесурса;
        }


        //[Key, ForeignKey(nameof(СправочникРесурсов))]
        //[Column(Order = 0)]
        //public int РесурсId { get; set; }

        //[Key, ForeignKey(nameof(СиловойАгрегатВУстановке))]
        //[Column(Order = 1)]
        //public int СиловойАгрегатВУстановкеId { get; set; }

        //[Key, ForeignKey(nameof(ТехнологическоеУстройство))]
        //[Column(Order = 1)]
        //public int УстановкаId { get; set; }

        //[Key, ForeignKey(nameof(РежимРаботыСиловогоАгретата))]
        //[Column(Order = 2)]
        //public int РежимРаботыАгрегатаId { get; set; }

        //[Key, ForeignKey(nameof(РежимРаботыУстановкиFK))]
        //[Column(Order = 3)]
        //public int РежимРаботыУстановкиId { get; set; }

        //public virtual РежимРаботыАгрегата РежимРаботыСиловогоАгретата { get; set; }
        //public virtual РежимРаботыУстановки РежимРаботыУстановкиFK { get; set; }
        //public virtual ТехнологическаяУстановка ТехнологическоеУстройство { get; set; }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int СиловойАгрегатВУстановкеFK { get; set; }
        public int СправочникРесурсовFK { get; set; }

        //public virtual СиловойАгрегатВУстановке СиловойАгрегатВУстановке { get; set; }
        //public virtual СправочникРесурсов СправочникРесурсов { get; set; }
    }
}
