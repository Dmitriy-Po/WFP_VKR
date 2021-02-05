namespace TestCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ФактическоеПотребление
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime ВремяЗамераПотребления { get; set; } = DateTime.Now;
        public decimal ЗначениеПотребления { get; set; }    
        public virtual ПланНормативныйТехнологический ПланНормативныйТехнологический { get; set; }
    }
}
