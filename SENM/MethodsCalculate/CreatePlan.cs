using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeFirst.Calculation_classess
{
    class CreatePlan
    {
        private void m1()
        {
            using (CodeFirstContext cfx = new CodeFirstContext())
            {
                DbSet db = cfx.СправочникSet;
                foreach (Справочник item in db)
                {
                    //Console.WriteLine("{0} - {1}\n{2}", item.ДатаНачала, item.ДатаЗавершения, item.Описание);
                }
                //Справочник  справочник = new Справочник();
                //справочник.ДатаНачала = DateTime.Now;
                //справочник.ДатаЗавершения = DateTime.Now.AddHours(4);
                //справочник.Описание = "Описание нового справочника";

                //cfx.СправочникSet.Add(справочник);
                //cfx.SaveChanges();
            }
        }
    }
}
