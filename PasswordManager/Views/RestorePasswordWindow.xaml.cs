using PasswordManager.Core.Data;
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
    /// Interaction logic for RestorePasswordWindow.xaml
    /// </summary>
    public partial class RestorePasswordWindow : Window
    {
        public RestorePasswordWindow()
        {
            InitializeComponent();
        }

        private void ButtonChangePassword_Click(object sender, RoutedEventArgs e)
        {
            var isMatch = Regex.IsMatch(PassBoxPassword.Password, @"^(?=.*?[A-Z])(?=(.*[a-z]){1,})(?=(.*[\d]){1,})(?=(.*[\W]){1,})(?!.*\s).{8,}$");
            if (!isMatch)
            {
                MessageBox.Show("Пароль должен содержать: только латиницу, хотя бы однцу цифру, одну строчную и прописную букву");

            }
            else
            {
                using var db = new PasswordManagerContext();
                var checkEmailWindow = new EmailWindow(TextBoxEmail.Text);
                checkEmailWindow.ShowDialog();
                if (checkEmailWindow.IsAuthorized)
                {
                    var salt = Security.SecurityHelper.GenerateSalt();
                    var saltedHash = Security.SecurityHelper.GenerateSaltedHash(PassBoxPassword.Password, salt);
                    var user = db.Users.First(x => x.Email == TextBoxEmail.Text);
                    user.SaltedHash = saltedHash;
                    user.Salt = salt;
                    db.SaveChanges();
                    Close();
                }
            }
        }
    }
}
