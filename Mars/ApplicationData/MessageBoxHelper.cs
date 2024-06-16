using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mars.ApplicationData
{
    public class MessageBoxHelper
    {
        /// <summary>
        /// Функция отображает сообщение об ошибке.
        /// </summary>
        /// <param name="text"> Текст ошибки. </param>
        /// <param name="title"> Заголовок ошибки. </param>
        public static void Error(string text, string title = "Ошибка")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        /// <summary>
        /// Функция отображает сообщение для информирования.
        /// </summary>
        /// <param name="text"> Текст информации. </param>
        /// <param name="title"> Заголовок информации. </param>
        public static void Information(string text, string title = "Информация")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Функция отображает сообщение для предупреждения.
        /// </summary>
        /// <param name="text"> Текст предупреждения. </param>
        /// <param name="title"> Заголовок предупреждения. </param>
        public static void Warning(string text, string title = "Предупреждение")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
