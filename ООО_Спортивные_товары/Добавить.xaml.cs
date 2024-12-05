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
    /// Логика взаимодействия для Добавить.xaml
    /// </summary>
    public partial class Добавить : Window
    {
        public Добавить()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы редактируете товар");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы успешно добавили товар!");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы точно хотите удалить товар?");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы успешно добавили товар!");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы редактируете товар");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы точно хотите удалить товар?");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы успешно добавили товар!");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы точно хотите удалить товар?");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы редактируете товар");
        }
    }
}
