using Desktop_Auth.Base;
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
    public partial class AuthorizationPage : Page
    {
        private string accessCode; // Поле для хранения сгенерированного кода доступа
        public AuthorizationPage()
        {
            InitializeComponent();
        }
        private void Button_InputClick(object sender, RoutedEventArgs e)
        {
            string employeeNumber = TxbNumber.Text;
            string password = TxbPassword.Text;

            var currentUser = AppData.db.Authorization.FirstOrDefault(u => u.Number == TxbNumber.Text && u.Password == TxbPassword.Text);
            if (currentUser != null && currentUser.Password == password)
            {
                // Генерируем код доступа
                accessCode = GenerateAccessCode();

                // Открываем модальное окно с сгенерированным кодом доступа
                MessageBox.Show($"Ваш код доступа: {accessCode}", "Код доступа", MessageBoxButton.OK, MessageBoxImage.Information);
                
                TxbCode.IsEnabled = true;
                TxbCode.Focus();
            }
            else
            {
                MessageBox.Show("Неправильный номер сотрудника или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_CancelClick(object sender, RoutedEventArgs e)
        {
            TxbNumber.Text = "";     // Очистить поле ввода номера
            TxbPassword.Text = "";   // Очистить поле ввода пароля
            TxbCode.Text = "";
            MessageBox.Show("Вы отменили ввод", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_ReloadClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Обновление кода", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void EmployeeNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string employeeNumber = TxbNumber.Text;

                // Проверяем наличие номера сотрудника в базе данных
                if (CheckEmployeeNumber(employeeNumber))
                {
                    TxbPassword.IsEnabled = true;
                    TxbPassword.Focus(); // Устанавливаем фокус на поле ввода пароля
                }
                else
                {
                    MessageBox.Show("Введённый номер не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void TxbCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string enteredCode = TxbCode.Text;

                if (enteredCode == accessCode)
                {
                    // Переходим на другую страницу после правильного ввода кода доступа
                    NavigationService.Navigate(new RolePage());
                }
                else
                {
                    MessageBox.Show("Неправильный код доступа", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private bool CheckEmployeeNumber(string employeeNumber)
        {
            var currentUser = AppData.db.Authorization.FirstOrDefault(u => u.Number == employeeNumber);
            return currentUser != null;
        }

        private string GenerateAccessCode()
        {
            // Генерируем код доступа (8 символов, латиница, верхний и нижний регистр, спецсимвол, цифра)
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";
            Random random = new Random();
            StringBuilder accessCodeBuilder = new StringBuilder();

            for (int i = 0; i < 8; i++)
            {
                int index = random.Next(0, characters.Length);
                accessCodeBuilder.Append(characters[index]);
            }

            return accessCodeBuilder.ToString();
        }
    }
}


