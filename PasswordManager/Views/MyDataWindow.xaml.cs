using PasswordManager.Core.Data;
using PasswordManager.Core.Models;
using PasswordManager.Resources;
using PasswordManager.Security;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for ServicesWindow.xaml
    /// </summary>
    public partial class MyDataWindow : Window
    {
        private User _user;
        public MyDataWindow()
        {
            InitializeComponent();
            using var db = new PasswordManagerContext();
            var salt = SecurityHelper.GenerateSalt();
            _user = db.Users.First(x => x.UserId == UserSettings.Default.UserID);
            TextBoxLogin.Text = _user.Login;
            DatePickerBirthDate.SelectedDate = _user.Birthdate;
            TextBoxEmail.Text = _user.Email;
            TextBoxLastName.Text = _user.LastName;
            TextBoxFirstName.Text = _user.FirstName;
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
            var isMatch = SecurityHelper.CompareByteArrays(SecurityHelper.GenerateSaltedHash(PassBoxOldPassword.Password, _user.Salt), _user.SaltedHash);
            if (!isMatch)
            {
                _errors.Add("- Не верный пароль");
                allValid = false;
            }
            if (PassBoxPassword.Password.Length >= 0)
            {
                isMatch = PassBoxRepeatPassword.Password == PassBoxPassword.Password;
                if (!isMatch)
                {
                    _errors.Add("- Пароли должны совпадать");
                    allValid = false;
                }
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

            TextBlockValidation.Text = !allValid ? string.Join("\n", _errors) : string.Empty;
            TextBlockValidation.Visibility = !allValid ? Visibility.Visible : Visibility.Collapsed;

            return allValid;
        }

        private async void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if (CheckValid())
            {
                using var db = new PasswordManagerContext();
                var user = db.Users.First(x => x.UserId == UserSettings.Default.UserID);
                if (PassBoxPassword.Password.Length > 0)
                {
                    var salt = SecurityHelper.GenerateSalt();
                    user.Salt = salt;
                    user.SaltedHash = SecurityHelper.GenerateSaltedHash(PassBoxPassword.Password, salt);
                }
                user.Login = TextBoxLogin.Text;
                user.Birthdate = DatePickerBirthDate.DisplayDate;
                user.Email = TextBoxEmail.Text;
                user.LastName = TextBoxLastName.Text;
                user.FirstName = TextBoxFirstName.Text;
                //var checkEmailWindow = new EmailWindow(user.Email);
                await db.SaveChangesAsync();
                Close();
                //checkEmailWindow.ShowDialog();
                //if (checkEmailWindow.IsAuthorized)
                //{
                //    await db.SaveChangesAsync();
                //    Close();
                //}
                //else
                //{
                //    MessageBox.Show("Подтвердите почту");
                //}
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
