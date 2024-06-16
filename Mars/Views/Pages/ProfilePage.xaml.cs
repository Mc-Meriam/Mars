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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mars.Views.Pages
{
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();

            // Заполнение полей данными о текущем пользователе 
            LoginUser currentUser = LoginUser.Instance;
            NameTb.Text = currentUser.NameU;
            LoginTb.Text = currentUser.LoginU;
            PhoneTb.Text = currentUser.PhoneU;
            SurnameTb.Text = currentUser.SurnameU;
            PassPb.Password = currentUser.PasswordU;
            
            
            // Другие свойства пользователя можно также присвоить соответствующим полям на странице

            // Обработчик нажатия на кнопку "Сохранить"
            SaveCreateProfiletBtn.Click += SaveCreateProfiletBtn_Click;
        }

        private void SaveCreateProfiletBtn_Click(object sender, RoutedEventArgs e)
        {
            // Код для сохранения измененных данных профиля пользователя
            // Например, можно обновить свойства текущего пользователя на основе введенных данных
            LoginUser currentUser = LoginUser.Instance;
            currentUser.NameU = NameTb.Text;
            currentUser.LoginU = LoginTb.Text;
            currentUser.SurnameU = SurnameTb.Text;
            currentUser.PhoneU = PhoneTb.Text;
            currentUser.PasswordU = PassPb.Password;

            App.context.SaveChanges();
            MessageBox.Show("Данные успешно сохранены");
            
            // Обновите другие свойства пользователя согласно введенным данным

            // Дополнительный код для сохранения изменений, если необходимо
        }
    }
}