namespace TestCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Справочник
    {
        public Справочник() { }
        public Справочник(
            string описание, 
            DateTime датаНачала, 
            DateTime датаЗавершения)
        {
            Описание = описание;
            ДатаНачала = датаНачала;
            ДатаЗавершения = датаЗавершения;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime ДатаНачала { get; set; } = DateTime.Now;
        public DateTime ДатаЗавершения { get; set; } = DateTime.Now;
        public string Описание { get; set; }
    }
}
