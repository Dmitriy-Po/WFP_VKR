using System.Windows;
using TestCodeFirst.DataContext;
using TestCodeFirst.ViewModels;
using WPF_SENM.Планы;
using WPF_SENM.Устройство;

namespace WPF_SENM
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DeviceListForm deviceList = new DeviceListForm();
            deviceList.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            СписокРесурсов списокРесурсов = new СписокРесурсов();
            списокРесурсов.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (DGDays.SelectedItem == null)
            {
                MessageBox.Show("Не выбран день, за который требуется показать нормы по установкам.\nВыберите месяц, а затем день, в графе \"Календарный день\".",
                    "Внимание", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                НормыПоУстановкам нормыПоУстановкам = new НормыПоУстановкам();
                нормыПоУстановкам.DataContext = new НормыПоУстановкамиVM(DGDays.SelectedItem as ПланПроизводстваПоДням);
                нормыПоУстановкам.ShowDialog();
            }
        }
    }
}
