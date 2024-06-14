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
    /// <summary>
    /// Логика взаимодействия для CatalogPage.xaml
    /// </summary>
    public partial class CatalogPage : Page
    {
        decimal totalCost;
        public CatalogPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ProductLb.ItemsSource = App.context.Product.ToList();
            ProductLV.SelectedItem = App.context.Product.ToList();
        }
        private string GetTotalCost()
        {
            try
            {
                totalCost = 0;
                if (ProductLV.Items != null)
                {
                    foreach (var item in ProductLV.Items)
                    {
                        if (item is Product product)
                        {
                            totalCost += product.Cost;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBoxHelper.Error(exception.Message);
            }
            return "К оплате: " + totalCost + "₽";
        }
        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (SearchTb.Text != string.Empty)
            //{
            //    try
            //    {
            //        CatalogLv.ItemsSource = App.context.User.Where(u => u.Surname.Contains(SearchTb.Text)).ToList();
            //    }
            //    catch (Exception exeption)
            //    {
            //        MessageBoxHelper.Error(exeption.Message);
            //    }
            //}
            //else
            //{
            //    CatalogLv.ItemsSource = App.context.User.ToList();
            //}
            if (SearchTb.Text != string.Empty)
            {
                ProductLb.ItemsSource = App.context.Product.Where(p => p.Name.Contains(SearchTb.Text)).ToList();
            }
            else
            {
                ProductLb.ItemsSource = App.context.Product.ToList();
            }
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow createWindow = new CreateWindow();
            createWindow.Show();
        }

        private void ProductLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //!!! добавлять только не пустые элементы!!!
            if (ProductLb.SelectedItem as Product!= null)
            {
                ProductLV.Items.Add(ProductLb.SelectedItem as Product);
                TotalCostTbl.Text = GetTotalCost();
            }
            //сбросить выбор элемента из списка
            ProductLb.SelectedIndex = -1;
        }

        private void ProductLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ProductLV.Items.Remove(ProductLV.SelectedItem as Product);
            }
            catch(Exception exception)
            {
                MessageBoxHelper.Error(exception.Message);
            }
            TotalCostTbl.Text = GetTotalCost();
        }

        private void AddProductBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
