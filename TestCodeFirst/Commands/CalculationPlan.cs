using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using TestCodeFirst.DataContext;
using TestCodeFirst.ViewModels;

namespace TestCodeFirst.Commands 
{
    [NotMapped]
    public class CalculationPlan : BaseClassOnChanged
    {
        private DateTime selectedDateStart;
        private DateTime selectedDateEnd;
        private CreateDataListCommand createDataCommand;
        private ObservableCollection<DataResult> dataResult;

        public DateTime SelectedDateStart
        {
            get { return selectedDateStart; }
            set
            {
                selectedDateStart = value;
                OnChangerd(nameof(SelectedDateStart));
            }
        }
        public DateTime SelectedDateEnd
        {
            get { return selectedDateEnd; }
            set
            {
                selectedDateEnd = value;
                OnChangerd(nameof(SelectedDateEnd));
            }
        }

        public ObservableCollection<DataResult> DataResults 
        {
            get { return dataResult; }
            set
            {
                dataResult = value;
                OnChangerd(nameof(DataResults));
            }
        }
        public CreateDataListCommand CreateDataCommand => createDataCommand 
            ?? (createDataCommand = new CreateDataListCommand(UpdateDataResult));

        public CalculationPlan()
        {
            UpdateDataResult();
        }

        private void UpdateDataResult()
        {
            //DataResults = GetResults(selectedDateStart, selectedDateEnd);            
        }

        public void/* ObservableCollection<DataResult>*/ GetResults(DateTime dateBegin, DateTime dateEnd)
        {
            //TODO 2021-01-16: Добвить в расчёт планы, котоырй расчитываются относительно времени а не объёма производства.
            //using (CodeFirstContext cfc = new CodeFirstContext())
            //{
            //    cfc.СправочникSet
            //        .Where(w => w.ДатаНачала >= dateBegin && w.ДатаЗавершения <= dateEnd)
            //        //.Where(w => w.Id > 28)
            //        .Load();
            //    cfc.РежимРаботыАгрегатаSet.Load();
            //    cfc.УстройствоSet.Load();
            //    cfc.СиловойАгрегатВУстройствеSet.Load();

            //    var режимыРаботы = cfc.РежимРаботыАгрегатаSet.Local;

            //    // Группировка планов по полю с типом потребляемого энергоресурса.
            //    var groupinglColelction = cfc
            //        .СправочникSet
            //        .Local
            //        .Cast<ПланНормативныйТехнологический>()
            //        .GroupBy
            //        (g => new
            //        {
            //            typee = cfc
            //                .СиловойАгрегатВУстройствеSet
            //                .Local
            //                .Where(w => w.Id == g.ТипЭнергииId)
            //                ?.FirstOrDefault()
            //                .ТипЭнергии
            //        });


            //    DataResults = new ObservableCollection<DataResult>();
            //    decimal суммаПоТипуЭнергии = 0;

            //    foreach (var group in groupinglColelction)
            //    {
            //        string nameEnergy = group.Key.typee.Value.ToString();
            //        суммаПоТипуЭнергии = 0;
            //        foreach (ПланНормативныйТехнологический plan in group)
            //        {
            //            decimal производительность = режимыРаботы
            //                .Where(w => w.Id == plan.РежимРаботыId)
            //                .FirstOrDefault()
            //                .Производительность;

            //            plan.КоличествоЧасовРаботы = plan.ЦелевойОбъёмПроизводства / производительность;

            //            суммаПоТипуЭнергии += (plan.КоличествоЧасовРаботы * режимыРаботы
            //            .Where(w => w.Id == plan.РежимРаботыId)
            //            .FirstOrDefault().Потребление);
            //        }

            //        DataResults.Add(new DataResult(nameEnergy, Math.Round(суммаПоТипуЭнергии, 2, MidpointRounding.AwayFromZero)));
            //    }

            //    return DataResults;
            //}
        }
    }
}
