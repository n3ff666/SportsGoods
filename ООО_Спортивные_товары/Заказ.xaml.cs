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
    /// Логика взаимодействия для Заказ.xaml
    /// </summary>
    public partial class Заказ : Window
    {
        public Заказ()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы успешно оформили заказ.", "Успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
            Client client = new Client();
            client.Show();
            this.Close();
        }
    }
}
