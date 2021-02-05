using System.Windows;
using TestCodeFirst;
using TestCodeFirst.DataContext;
using TestCodeFirst.ViewModels;

namespace WPF_SENM.Устройство
{
    /// <summary>
    /// Логика взаимодействия для DeviceListForm.xaml
    /// </summary>
    public partial class DeviceListForm : Window
    {
        public DeviceListForm()
        {
            InitializeComponent();
        }
        private bool IsNullSelectedItem()
        {
            bool res = false;
            if (DGDevices.SelectedItem == null)
            {
                MessageBox.Show("Не выбрана установка.\nЧтобы продолжить, выберите её в списке установок.",
                    "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);

                res = true;
            }

            return res;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!IsNullSelectedItem())
            {
                DeviceEditForm deviceEdit = new DeviceEditForm();
                deviceEdit.DataContext = new СиловойАгрегатVM(DGDevices.SelectedItem as ТехнологическаяУстановка);
                deviceEdit.ShowDialog();
            }            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!IsNullSelectedItem())
            {
                DeviceOperationModes deviceOperationModes = new DeviceOperationModes();
                deviceOperationModes.DataContext = new РежимРаботыУстановкиVM(DGDevices.SelectedItem as ТехнологическаяУстановка);
                deviceOperationModes.ShowDialog();
            }           
        }
    }
}
