using PasswordManager.Resources;
using PasswordManager.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace PasswordManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            if (!UserSettings.Default.IsAuthorised)
            {
                new AuthorisationWindow().Show();
            }
            else
            {
                new MenuWindow().Show();
            }
        }
    }
}
