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

namespace Desktop_Auth.Views
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }
        private void Button_InputClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы вошли в ситему", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_CancelClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы отменили ввод", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_ReloadClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Обновление кода", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
