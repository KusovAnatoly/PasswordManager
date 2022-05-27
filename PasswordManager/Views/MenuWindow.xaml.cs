using Microsoft.EntityFrameworkCore;
using PasswordManager.Core.Data;
using PasswordManager.Core.Models;
using PasswordManager.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PasswordManager.Views
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        private string _searchQuery = string.Empty;
        public MenuWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var db = new PasswordManagerContext())
            {
                var data = db.ServicePasswords
                    .Include(x => x.Service)
                    .Include(x => x.User)
                    .AsQueryable();

                if (!string.IsNullOrEmpty(_searchQuery))
                {
                    data = data.Where(x => (x.Note + x.Service.Name + x.Service.Url + x.UserName).Contains(_searchQuery));
                }

                DataGridPasswords.ItemsSource = data.ToList();
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _searchQuery = (sender as TextBox)!.Text;
            LoadData();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            new AddEditWindow().ShowDialog();
            LoadData();
        }

        private void DataGridPasswords_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGridPasswords.SelectedIndex != -1)
            {
                ButtonEdit.IsEnabled = true;
            }
            else
            {
                ButtonEdit.IsEnabled = false;
            }
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            new AddEditWindow(DataGridPasswords.SelectedItem as ServicePassword).ShowDialog();
            LoadData();
        }

        private void ButtonMyData_Click(object sender, RoutedEventArgs e)
        {
            new MyDataWindow().ShowDialog();
        }

        private void MenuItemMyData_Click(object sender, RoutedEventArgs e)
        {
            new MyDataWindow().ShowDialog();
        }

        private void MenuItemSignOut_Click(object sender, RoutedEventArgs e)
        {
            UserSettings.Default.IsAuthorised = false;
            UserSettings.Default.UserID = new Guid();
            UserSettings.Default.Save();
            new AuthorisationWindow().Show();
            Close();
        }
    }
}
