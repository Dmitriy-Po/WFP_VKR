using System.Linq;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using TestCodeFirst.WorkWithCollection;
using TestCodeFirst.DataContext;
using TestCodeFirst.Commands;

namespace TestCodeFirst.ViewModels
{
    [NotMapped]
    public class НормыПоУстановкамиVM : BaseClassOnChanged
    {
        private readonly CodeFirstContext cfc;
        private ДневнаяНормаНаУстановку selectedNorm;
        private UpdateCommand updateCommand;
        private ObservableCollection<ДневнаяНормаНаУстановку> dayOfNorm;

        public ObservableCollection<ДневнаяНормаНаУстановку> DayOfNorm
        {
            get { return dayOfNorm; }
            set
            {
                dayOfNorm = value;
                OnChangerd(nameof(DayOfNorm));
            }
        }
        public ObservableCollection<СиловойАгрегатВУстановке> Resources { get; set; }

        public UpdateCommand UpdateCommand => updateCommand ?? (updateCommand = new UpdateCommand(UpdateDayOfNorm));

        private void UpdateDayOfNorm()
        {
            DayOfNorm
                .ToList()
                .ForEach(x => cfc.Entry(x).Reload());
            DayOfNorm = WorkCollection.GetДневнаяНормаНаУстановку<ДневнаяНормаНаУстановку>(cfc);
        }

        public ДневнаяНормаНаУстановку SelectedNorm
        {
            get { return selectedNorm; }
            set
            {
                selectedNorm = value;
                cfc.SaveChanges();
                OnChangerd(nameof(SelectedNorm));                
            }
        }

        public НормыПоУстановкамиVM(ПланПроизводстваПоДням планПроизводстваПоДням)
        {
            cfc = new CodeFirstContext();
            cfc.УстановкаSet.Load();
            cfc.РежимРаботыАгрегатаSet.Load();
            cfc.РежимРаботыУстановкиSet.Load();
            cfc.СиловойАгрегатВУстройствеSet.Load();

            cfc.ДневнаяНормаНаУстановкуSet
                .Where(w => w.ПланПроизводстваПоДням.Id == планПроизводстваПоДням.Id)
                .Load();

            DayOfNorm = WorkCollection.GetДневнаяНормаНаУстановку<ДневнаяНормаНаУстановку>(cfc);
            //TODO 2021-01-21: Доделать список ресурсов и по мелочи :), удачи тебе Дмитрий, ты справишся!
        }
    }
}
