using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeFirst.Commands
{
    [NotMapped]
    public class DataResult
    {
        public DataResult(string nameResource, decimal val)
        {
            NameResource = nameResource;
            Value = val;
        }
        public string NameResource { get; set; }
        public decimal Value { get; set; }
    }
}
