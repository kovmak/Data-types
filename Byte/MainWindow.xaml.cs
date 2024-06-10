using System.Windows;
using System.Windows.Controls;
using System.IO;
using System;

namespace Byte
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void ByteButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = "data\\byte.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            FilesWindow filesWindow = new FilesWindow();
            string fileContent = File.ReadAllText(filePath);
            TextBlock fileTextBlock = (TextBlock)filesWindow.FindName("FileTextBlock");
            fileTextBlock.Text = fileContent;
            filesWindow.Show();
        }
        private void BoolButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = "data\\bool.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            FilesWindow filesWindow = new FilesWindow();
            string fileContent = File.ReadAllText(filePath);
            TextBlock fileTextBlock = (TextBlock)filesWindow.FindName("FileTextBlock");
            fileTextBlock.Text = fileContent;
            filesWindow.Show();
        }
        private void SByteButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = "data\\sbyte.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            FilesWindow filesWindow = new FilesWindow();
            string fileContent = File.ReadAllText(filePath);
            TextBlock fileTextBlock = (TextBlock)filesWindow.FindName("FileTextBlock");
            fileTextBlock.Text = fileContent;
            filesWindow.Show();
        }
        private void StringButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = "data\\string.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            FilesWindow filesWindow = new FilesWindow();
            string fileContent = File.ReadAllText(filePath);
            TextBlock fileTextBlock = (TextBlock)filesWindow.FindName("FileTextBlock");
            fileTextBlock.Text = fileContent;
            filesWindow.Show();
        }
        private void DoubleButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = "data\\double.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            FilesWindow filesWindow = new FilesWindow();
            string fileContent = File.ReadAllText(filePath);
            TextBlock fileTextBlock = (TextBlock)filesWindow.FindName("FileTextBlock");
            fileTextBlock.Text = fileContent;
            filesWindow.Show();
        }
        private void FloatButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = "data\\float.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            FilesWindow filesWindow = new FilesWindow();
            string fileContent = File.ReadAllText(filePath);
            TextBlock fileTextBlock = (TextBlock)filesWindow.FindName("FileTextBlock");
            fileTextBlock.Text = fileContent;
            filesWindow.Show();
        }
        private void IntButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = "data\\int.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            FilesWindow filesWindow = new FilesWindow();
            string fileContent = File.ReadAllText(filePath);
            TextBlock fileTextBlock = (TextBlock)filesWindow.FindName("FileTextBlock");
            fileTextBlock.Text = fileContent;
            filesWindow.Show();
        }
        private void UIntButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = "data\\uint.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            FilesWindow filesWindow = new FilesWindow();
            string fileContent = File.ReadAllText(filePath);
            TextBlock fileTextBlock = (TextBlock)filesWindow.FindName("FileTextBlock");
            fileTextBlock.Text = fileContent;
            filesWindow.Show();
        }
        private void LongButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = "data\\long.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            FilesWindow filesWindow = new FilesWindow();
            string fileContent = File.ReadAllText(filePath);
            TextBlock fileTextBlock = (TextBlock)filesWindow.FindName("FileTextBlock");
            fileTextBlock.Text = fileContent;
            filesWindow.Show();
        }
        private void ObjectButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = "data\\object.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            FilesWindow filesWindow = new FilesWindow();
            string fileContent = File.ReadAllText(filePath);
            TextBlock fileTextBlock = (TextBlock)filesWindow.FindName("FileTextBlock");
            fileTextBlock.Text = fileContent;
            filesWindow.Show();
        }
        private void ULongButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = "data\\ulong.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            FilesWindow filesWindow = new FilesWindow();
            string fileContent = File.ReadAllText(filePath);
            TextBlock fileTextBlock = (TextBlock)filesWindow.FindName("FileTextBlock");
            fileTextBlock.Text = fileContent;
            filesWindow.Show();
        }
        private void UShortButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = "data\\ushort.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            FilesWindow filesWindow = new FilesWindow();
            string fileContent = File.ReadAllText(filePath);
            TextBlock fileTextBlock = (TextBlock)filesWindow.FindName("FileTextBlock");
            fileTextBlock.Text = fileContent;
            filesWindow.Show();
        }
    }
}
