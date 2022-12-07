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
using System.Net;

namespace MusicPlayer
{
    /// <summary>
    /// Логика взаимодействия для Enter.xaml
    /// </summary>
    public partial class Enter : Window
    {
        public Enter()
        {
            InitializeComponent();
        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }
        private const string defaultText = "Введите логин";

        public void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            login.Text = login.Text == string.Empty ? defaultText : login.Text;
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            Parol.Visibility = Visibility.Collapsed;
            textBox.Visibility = Visibility.Visible;

            textBox.Text = new NetworkCredential(string.Empty, Parol.SecurePassword).Password;
            textBox.Focus();
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Parol.Visibility = Visibility.Visible;
            textBox.Visibility = Visibility.Collapsed;

            Parol.Password = textBox.Text;
            Parol.Focus();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
           if(login.Text == "Админ" && (Parol.Password == "Админ" || textBox.Text == "Админ")) 
            {
                main.Show();
                this.Close();
            }
           else
            {
                MessageBox.Show("Неправильно введены данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
