using System;
using System.Windows;
using System.Windows.Input;



namespace MusicPlayer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данная функция находится в разработке", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Данная функция находится в разработке", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Данная функция находится в разработке", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Данная функция находится в разработке", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Данная функция находится в разработке", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Данная функция находится в разработке", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Данная функция находится в разработке", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

       
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
