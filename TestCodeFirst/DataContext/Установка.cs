namespace TestCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TestCodeFirst.DataContext;

    public partial class Установка
    {
        public Установка() {}
        public Установка(
            string марка, 
            string модель, 
            string описание, 
            DateTime датаВыпуска)
        {
            Марка = марка;
            Модель = модель;
            Описание = описание;
            ДатаВыпуска = датаВыпуска;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int УстройствоId { get; set; }
        public string Марка { get; set; }
        public string Модель { get; set; }
        public string Описание { get; set; }
        public DateTime ДатаВыпуска { get; set; } = DateTime.Now;
    }
}
