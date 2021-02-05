using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TestCodeFirst;
using TestCodeFirst.DataContext;
using TestCodeFirst.ViewModels;

namespace WPF_SENM.Планы
{
    /// <summary>
    /// Логика взаимодействия для НормыПоУстановкам.xaml
    /// </summary>
    public partial class НормыПоУстановкам : Window
    {
        public НормыПоУстановкам()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DGNorms.SelectedItem == null)
            {
                MessageBox.Show("Не выбранна установка.\n\nЧтобы посмотреть потребляемые ресурсы установки, выберите её в списке, и затем нажните кнопку \"Список потребляемых ресурсов\".",
                    "Внимание", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                НормыПоУстановкамEditForm нормыПоУстановкамEditForm = new НормыПоУстановкамEditForm();
                нормыПоУстановкамEditForm.DataContext = new ДневнаяНормаVM(DGNorms.SelectedItem as ДневнаяНормаНаУстановку);
                нормыПоУстановкамEditForm.ShowDialog();    
            }
        }
    }
}
