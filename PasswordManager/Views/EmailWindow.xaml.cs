using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
    /// Interaction logic for EmailWindow.xaml
    /// </summary>
    public partial class EmailWindow : Window
    {
        public bool IsAuthorized { get; private set; } = false;
        private int Code { get; set; }
        public string Email { get; }

        public EmailWindow(string email)
        {
            InitializeComponent();
            Code = new Random().Next(1000, 9999);
            Email = email;
            SendMail();
        }

        private void SendMail()
        {
            string to = Email;

#warning Настроить отправку сообщения
            string from = "Менеджер паролей";

            MailMessage message = new MailMessage(from, to);
            message.Subject = "Авторизация";
            message.Body = $@"Код подтверждения регистрации: {Code}.";

#warning Настроить отправку сообщения

            SmtpClient client = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("email", "password"),
                EnableSsl = true,
            };

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught while sending message: {0}",
                    ex.ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(TextBoxCode.Text) == Code)
            {
                IsAuthorized = true;
                Close();
            }
            else
            {
                MessageBox.Show("Не верный код","Авторизация",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
