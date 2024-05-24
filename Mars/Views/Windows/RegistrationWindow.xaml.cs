using Mars.Models;
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
            if (LoginTb.Text == "")
            {
                MessageBox.Show("Введите логин");
            }
            if (PhoneTb.Text == "")
            {
                MessageBox.Show("Введите номер телефона");
            }
            if (PasswordPb.Password == "")
            {
                MessageBox.Show("Введите пароль");
            }
            
            User user = new User
            {
                Login = LoginTb.Text,
                Phone = PhoneTb.Text,
                Password = PasswordPb.Password
            };
            App.context.User.Add(user);
            App.context.SaveChanges();
            MessageBox.Show("Пользователь добавлен!");
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();    
            authorizationWindow.Show();
            this.Close();
        }
    }
}
