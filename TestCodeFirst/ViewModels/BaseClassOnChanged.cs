using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestCodeFirst.ViewModels
{
    [NotMapped]
    public class BaseClassOnChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnChangerd(string nameProperty = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameProperty));
        }
    }
}