using Mars.ApplicationData;
using Mars.Views.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mars.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ManufacturerPage.xaml
    /// </summary>
    public partial class ManufacturerPage : Page
    {
        public ManufacturerPage()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

            //App.context.SaveChanges();
            MessageBoxHelper.Information("Данные пользователя успешно изменены!");
        }

        private void AddProductBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow createWindow = new CreateWindow();
            createWindow.ShowDialog();
        }
    }
}
