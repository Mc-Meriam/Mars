using Mars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.ApplicationData
{
    public class LoginUser
    {
        public int Id { get; set; }
        public string NameU { get; set; }
        public string PhoneU { get; set; }
        public string LoginU { get; set; }
        public string PasswordU { get; set; }
        public string SurnameU { get; set; }

        public string UserRoleU 
        {
            get 
            { return RoleId == 1 ? "Покупатель" : (RoleId == 2 ? "Производитель" : ""); } 
        }
        public int RoleId { get; set; }
        // Добавьте другие необходимые свойства текущего пользователя

        private static LoginUser instance;

        public static LoginUser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginUser();
                }
                return instance;
            }
        }

        // Пример метода для установки текущего пользователя
        public void SetLoginUser(User user)
        {
            Id = user.ID;
            NameU = user.Name;
            RoleId = user.IdRole;
            PhoneU = user.Phone;
            LoginU = user.Login;
            PasswordU = user.Password;
            SurnameU = user.Surname;
            // Установите другие свойства текущего пользователя
        }
    }
}
