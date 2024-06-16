using Mars.ApplicationData;
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
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void HL1_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            this.Close();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            User user = App.context.User.FirstOrDefault(us => us.Login == LoginTb.Text && us.Password == PasswordPb.Password);

            if (user != null)
            {

                App.enteredUser = user;
                LoginUser.Instance.SetLoginUser(user);

                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBoxHelper.Error("Неправильно введен логин или пароль");
            }

            LoginTb.Text = "";
            PasswordPb.Password = "";
        }
    }
}

