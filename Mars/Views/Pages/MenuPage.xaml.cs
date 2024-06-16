using Mars.ApplicationData;
using Mars.Models;
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
    public partial class MenuPage : Page
    {
        User currentUserRole;

        public MenuPage(User currentUser)
        {
            InitializeComponent();
            currentUserRole = currentUser;

            //UpdateButtonVisibility();
        }

        //private void UpdateButtonVisibility()
        //{
        //    if (currentUserRole != null)
        //    {
        //        if (currentUserRole.IdRole == 1)
        //        {
        //            CreateBtn.Visibility = Visibility.Hidden;
        //        }
        //        else if (currentUserRole.IdRole == 2)
        //        {
        //            CreateBtn.Visibility = Visibility.Visible;
        //        }
        //    }
        //    else
        //    {
        //        CreateBtn.Visibility = Visibility.Hidden;
        //    }
        //}

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.FrameBody.Navigate(new ProfilePage());
        }

        private void CatalogBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.FrameBody.Navigate(new CatalogPage());
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            //CreateWindow createWindow = new CreateWindow();
            //createWindow.ShowDialog();
            AddProductWindow addProductWindow = new AddProductWindow();
            addProductWindow.ShowDialog();
        }

        //public void UpdateUserRole(User newUser)
        //{
        //    currentUserRole = newUser;
        //    UpdateButtonVisibility();
        //}

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (App.enteredUser.IdRole == 1)
            {
                CreateBtn.Visibility = Visibility.Collapsed;
            }
            else
            {
                CreateBtn.Visibility = Visibility.Visible;
            }
        }
    }
}