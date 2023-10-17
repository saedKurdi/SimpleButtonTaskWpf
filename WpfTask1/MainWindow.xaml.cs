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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTask1
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

        private void button_right_down(object sender, RoutedEventArgs e)
        {
            Button ?btn = sender as Button;
            main_grid.Children.Remove(btn);
            main_window.Title = btn!.Content.ToString();
        }

        private void button_left_down(object sender, RoutedEventArgs e)
        {
            Button? btn = sender as Button;
            byte r = (byte)Random.Shared.Next(0, 256);
            byte g = (byte)Random.Shared.Next(0, 256);
            byte b = (byte)Random.Shared.Next(0, 256);

            btn!.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
            MessageBox.Show($"Content:{btn.Content}\nHeight:{btn.Height}\nWidth:{btn.Width}");
        }
    }
}
