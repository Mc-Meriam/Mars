using Mars.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Mars.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        byte[] image_bytes;
        public AddProductWindow()
        {
            InitializeComponent();

            CategoryBtn.SelectedValuePath = "ID";
            CategoryBtn.DisplayMemberPath = "Name";
            CategoryBtn.ItemsSource = App.context.CategoryProduct.ToList();

            

        }

        private void SaveCreateProductBtn_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product()
            {
                Name = NameTb.Text,
                Image = image_bytes,
                CategoryProduct = CategoryBtn.SelectedItem as CategoryProduct,
                Size = SizeTb.Text,
                Cost = Convert.ToDecimal(CostTb.Text),

            };

            App.context.Product.Add(product);
            App.context.SaveChanges();

            this.Close();
        }

        private void PhotoImg_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); // создаем диалоговое окно
            openFileDialog.ShowDialog(); // показываем
            image_bytes = File.ReadAllBytes(openFileDialog.FileName);
            if (image_bytes == null) 
            {
                return;
            }
            
        }
    }
}
