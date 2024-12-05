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

namespace ООО_Спортивные_товары
{
    /// <summary>
    /// Логика взаимодействия для Регистрация.xaml
    /// </summary>
    public partial class Регистрация : Window
    {
        public Регистрация()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Получение данных из текстовых полей
            string name = nameTextBox.Text; // Имя пользователя
            string login = loginTextBox.Text; // Login
            string password = passwordTextBox.Text; // Пароль
            string confirmPassword = confirmPasswordTextBox.Text; // Подтверждение пароля

            // Валидация данных
            if (!name.ValidateUsername())
            {
                MessageBox.Show("Имя пользователя должно быть не менее 3 символов.");
                return;
            }

            if (!login.ValidateEmail())
            {
                MessageBox.Show("Введите корректный логин.");
                return;
            }

            if (!password.ValidatePassword())
            {
                MessageBox.Show("Пароль должен быть не менее 6 символов.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }

            // Если все данные корректны, выводим сообщение об успешной регистрации и открываем новое окно
            MessageBox.Show("Вы успешно зарегистрированы!");
            Главная главная = new Главная();
            главная.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Главная главная = new Главная();
            главная.Show();
            this.Close();
        }
    }
}
