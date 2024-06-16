using Mars.ApplicationData;
using Mars.Models;
using Mars.Views.Pages;
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

namespace Mars.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void ChoiceBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTb.Text) 
                ||string.IsNullOrEmpty(PhoneTb.Text)
                || string.IsNullOrEmpty(PasswordPb.Password))
            {
                MessageBoxHelper.Warning("Заполните все поля!");
            }
            else
            {
                try
                {
                    User user = new User
                    {
                        Login = LoginTb.Text,
                        Phone = PhoneTb.Text,
                        Password = PasswordPb.Password,
                        IdRole = 1
                    };
                    App.context.User.Add(user);
                    App.context.SaveChanges();
                    MessageBox.Show("Пользователь добавлен!");

                    LoginTb.Text = "";
                    PhoneTb.Text = "";
                    PasswordPb.Password = "";
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();

                    this.Close();
                }
                catch (Exception exception)
                {
                    MessageBoxHelper.Error(exception.Message);
                }
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();    
            authorizationWindow.Show();
            this.Close();
        }
    }
}
