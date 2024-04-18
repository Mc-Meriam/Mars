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
            //if (LoginTb.Text == "")
            //{
            //    MessageBox.Show("Введите логин");
            //}
            //if (PhoneTb.Text == "")
            //{
            //    MessageBox.Show("Введите номер телефона");
            //}
            //if (Password1Pb.Password == "")
            //{
            //    MessageBox.Show("Введите пароль");
            //}
            //if (Password2Pb.Password == "")
            //{
            //    MessageBox.Show("Введите пароль, пароли должны совпадать");
            //}
            //User user = new User
            //{
            //    Login = LoginTb.Text,
            //    Phone = PhoneTb.Text,
            //    Password = Password1Pb.Password
            //};
            //App.context.User.Add(user);
            //App.context.SaveChanges();
            //MessageBox.Show("Пользователь добавлен!");
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();    
            authorizationWindow.Show();
            this.Close();
        }
    }
}
