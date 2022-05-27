using PasswordManager.Core.Data;
using PasswordManager.Core.Models;
using PasswordManager.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PasswordManager.Views
{
    /// <summary>
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        public SignUpWindow()
        {
#warning ВАЛИДАЦИЯ ДАННЫХ
            InitializeComponent();
        }

        private List<string> _errors = new List<string>();

        private bool CheckValid()
        {
            _errors.Clear();
            bool allValid = true;
            if (TextBoxEmail.Text.Length < 5)
            {
                _errors.Add("- Электронная почта обязательная для заполнения");
                allValid = false;
            }
            if (Regex.IsMatch(TextBoxLogin.Text, @"^[A - Za - z].{ 8,32}$"))
            {
                _errors.Add("- Логин должен содержать минимум 8 латинских симолов");
                allValid = false;
            }
            var isMatch = Regex.IsMatch(PassBoxPassword.Password, @"^(?=.*?[A-Z])(?=(.*[a-z]){1,})(?=(.*[\d]){1,})(?=(.*[\W]){1,})(?!.*\s).{8,}$");
            if (!isMatch)
            {
                _errors.Add("- Пароль должен содержать: только латиницу, хотя бы однцу цифру, одну строчную и прописную букву");
                allValid = false;
            }
            isMatch = PassBoxRepeatPassword.Password == PassBoxPassword.Password;
            if (!isMatch)
            {
                _errors.Add("- Пароли должны совпадать");
                allValid = false;
            }
            if (string.IsNullOrEmpty(TextBoxFirstName.Text))
            {
                _errors.Add("- Имя не дожно быть путсым");
                allValid = false;
            }
            if (string.IsNullOrEmpty(TextBoxLastName.Text))
            {
                _errors.Add("- Фамилия не дожна быть пустой");
                allValid = false;
            }
            if (DatePickerBirthDate.SelectedDate > DateTime.Now.AddYears(-14) && DatePickerBirthDate.SelectedDate > DateTime.Now.AddYears(-14))
            {
                _errors.Add("- Дата рождения не позже: " + DateTime.Now.AddYears(-14).ToString("dd.MM.yyyy"));
                allValid = false;
            }
            if (CheckBoxAgree.IsChecked != true)
            {
                _errors.Add("- Необходимо согласиться с условиями");
                allValid = false;
            }

            TextBlockValidation.Text = !allValid ? string.Join("\n", _errors) : string.Empty;
            TextBlockValidation.Visibility = !allValid ? Visibility.Visible : Visibility.Collapsed;

            return allValid;
        }

        private async void ButtonSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (CheckValid())
            {
                using var db = new PasswordManagerContext();
                var salt = SecurityHelper.GenerateSalt();
                var user = new User
                {
                    Login = TextBoxLogin.Text,
                    Salt = salt,
                    SaltedHash = SecurityHelper.GenerateSaltedHash(PassBoxPassword.Password, salt),
                    Birthdate = DatePickerBirthDate.DisplayDate,
                    Email = TextBoxEmail.Text,
                    LastName = TextBoxLastName.Text,
                    FirstName = TextBoxFirstName.Text
                };
                var checkEmailWindow = new EmailWindow(user.Email);
                checkEmailWindow.ShowDialog();
                if (checkEmailWindow.IsAuthorized)
                {
                    await db.Users.AddAsync(user);
                    await db.SaveChangesAsync();
                    Close();
                }
                else
                {
                    MessageBox.Show("Подтвердите почту");
                }
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void PassBoxPassword_PasswordChanged(object sender, RoutedEventArgs e) => CheckValid();

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) => CheckValid();

        private void DatePickerBirthDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e) => CheckValid();

        private void CheckBoxAgree_Checked(object sender, RoutedEventArgs e) => CheckValid();

        private void CheckBoxAgree_Unchecked(object sender, RoutedEventArgs e) => CheckValid();
    }
}
