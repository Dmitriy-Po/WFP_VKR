namespace TestCodeFirst
{
    using DataContext;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ПланНормативныйТехнологический : Справочник
    {
        public ПланНормативныйТехнологический() {}
        public ПланНормативныйТехнологический(
            string описание,
            DateTime датаНачала,
            DateTime датаЗавершения)
            : base(
                  описание, 
                  датаНачала,
                  датаЗавершения)
        {
            this.ФактическоеПотребление = new ObservableCollection<ФактическоеПотребление>();
        }
        public decimal ЦелевойОбъёмПроизводства { get; set; }
        public decimal КоличествоЧасовРаботы { get; set; }
        public int УстройствоFK { get; set; }
        public int ТипЭнергииId { get; set; }
        public int РежимРаботыId { get; set; }
        public virtual ObservableCollection<ФактическоеПотребление> ФактическоеПотребление { get; set; }

        //TODO 2021-01-13: Добавить поле. Булево значение, является ли план отсносительно времени или объема производства.
        //TODO 2021-01-13: Добавить график обслуживания - те дни когда не работает устройство.
    }
}
