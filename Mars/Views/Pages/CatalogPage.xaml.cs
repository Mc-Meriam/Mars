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
    /// Логика взаимодействия для CatalogPage.xaml
    /// </summary>
    public partial class CatalogPage : Page
    {
        public CatalogPage()
        {
            InitializeComponent();
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchTb.Text != string.Empty)
            {
                try
                {
                    CatalogLv.ItemsSource = App.context.User.Where(u => u.Surname.Contains(SearchTb.Text)).ToList();
                }
                catch (Exception exeption)
                {
                    MessageBoxHelper.Error(exeption.Message);
                }
            }
            else
            {
                CatalogLv.ItemsSource = App.context.User.ToList();
            }
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow createWindow = new CreateWindow();
            createWindow.Show();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
