using System;
using System.Collections.Generic;
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

namespace WPF_SENM.Устройство
{
    /// <summary>
    /// Логика взаимодействия для DeviceEditForm.xaml
    /// </summary>
    public partial class DeviceEditForm : Window
    {
        public DeviceEditForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OperatingMode operatingMode = new OperatingMode();
            //operatingMode.DataContext = new РежимРаботыVM(DGPowerType.SelectedItem as УстройствоРежимРесурс);
            operatingMode.DataContext = new РежимРаботыVM(DGPowerType.SelectedItem as СиловойАгрегатВУстановке);
            operatingMode.ShowDialog();
        }
    }
}
