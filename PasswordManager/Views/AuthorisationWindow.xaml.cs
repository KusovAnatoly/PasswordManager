using PasswordManager.Core.Data;
using PasswordManager.Security;
using PasswordManager.Resources;
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

namespace PasswordManager.Views
{
    /// <summary>
    /// Interaction logic for AuthorisationWindow.xaml
    /// </summary>
    public partial class AuthorisationWindow : Window
    {
        public AuthorisationWindow()
        {
            InitializeComponent();
        }

        private void ButtonSignIn_Click(object sender, RoutedEventArgs e)
        {
            using var db = new PasswordManagerContext();
            if (db.Users.Any(x => x.Login == TextBoxLogin.Text))
            {
                var user = db.Users.First(x => x.Login == TextBoxLogin.Text);
                var saltedHash = SecurityHelper.GenerateSaltedHash(PassBoxPassword.Password, user.Salt);
                if (SecurityHelper.CompareByteArrays(saltedHash, user.SaltedHash))
                {
                    if (CheckBoxRememberMe.IsChecked == true)
                    {
                        UserSettings.Default.IsAuthorised = true;
                    }
                    UserSettings.Default.UserID = user.UserId;
                    UserSettings.Default.Save();
                    new MenuWindow().Show();
                    Close();
                }
            }
        }

        private void ButtonSignUp_Click(object sender, RoutedEventArgs e)
        {
            new SignUpWindow().Show();
        }
    }
}
