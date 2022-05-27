using PasswordManager.Core.Data;
using PasswordManager.Core.Models;
using PasswordManager.Resources;
using PasswordManager.Security;
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
    /// Interaction logic for AddEditWindow.xaml
    /// </summary>
    public partial class AddEditWindow : Window
    {
        public AddEditWindow()
        {
            InitializeComponent();
            LoadServices();
        }

        public AddEditWindow(ServicePassword servicePassword)
        {
            InitializeComponent();
            LoadServices();
            ServicePassword = servicePassword;
            TextBoxPassword.Text = servicePassword.Password;
            TextBoxUserName.Text = servicePassword.UserName;
            TextBoxNote.Text = servicePassword.Note;
            ComboBoxServices.SelectedIndex = ComboBoxServices.Items.IndexOf(ComboBoxServices.Items.OfType<Service>().FirstOrDefault(x => x.ServiceId == servicePassword.ServiceId));
            ButtonAdd.Visibility = Visibility.Collapsed;
            ButtonEdit.Visibility = Visibility.Visible;
        }

        public ServicePassword ServicePassword { get; }

        private void LoadServices()
        {
            using (var db = new PasswordManagerContext())
            {

                ComboBoxServices.ItemsSource = db.Services.ToList();
                ComboBoxServices.SelectedIndex = 0;
            }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new PasswordManagerContext())
            {

                db.ServicePasswords.Add(new ServicePassword
                {
                    Password = TextBoxPassword.Text,
                    UserName = TextBoxUserName.Text,
                    Note = TextBoxNote.Text,
                    UserId = UserSettings.Default.UserID,
                    ServiceId = (ComboBoxServices.SelectedItem as Service).ServiceId
                });
                db.SaveChanges();
                Close();
            }
        }

        private void ButtonGeneratePassword_Click(object sender, RoutedEventArgs e)
        {
            TextBoxPassword.Text = new PasswordGenerator().Generate();
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new PasswordManagerContext())
            {
                var password = db.ServicePasswords.First(x => x.ServiceId == ServicePassword.ServiceId);
                password.Password = TextBoxPassword.Text;
                password.UserName = TextBoxUserName.Text;
                password.Note = TextBoxNote.Text;
                password.UserId = UserSettings.Default.UserID;
                password.ServiceId = (ComboBoxServices.SelectedItem as Service).ServiceId;
                db.SaveChanges();
                Close();
            }
        }
    }
}
