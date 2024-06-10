using System.Windows;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Byte
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            Close();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Password;
            string loginFilePath = "login.xml";

            if (File.Exists(loginFilePath))
            {
                XElement loginXml = XElement.Load(loginFilePath);
                if (loginXml.Elements("user").Any(x => (string)x.Attribute("name") == username && (string)x.Attribute("password") == password))
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                    return;
                }
            }
            MessageBox.Show("Невірні данні");
            return;
        }
    }
}