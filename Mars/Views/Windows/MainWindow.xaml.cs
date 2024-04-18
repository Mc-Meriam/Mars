using Mars.ApplicationData;
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

namespace Mars
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameClass.FrameMenu = FrameMenuMain;
            FrameMenuMain.Navigate(new Views.Pages.MenuPage());

            FrameClass.FrameBody = FrameBodyMain;
            FrameBodyMain.Navigate(new Views.Pages.CatalogPage());
        }
    }
}
