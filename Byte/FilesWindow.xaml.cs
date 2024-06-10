using System.Windows;

namespace Byte
{
    /// <summary>
    /// Логика взаимодействия для FilesWindow.xaml
    /// </summary>
    public partial class FilesWindow : Window
    {
        public FilesWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
