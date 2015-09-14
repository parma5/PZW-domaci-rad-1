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

namespace dr1
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

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect.Height = 60;
            rect.Width = 60;
            rect.Fill = Brushes.Chocolate;
            rect.Margin = new Thickness(0, 5, 0, 0);
            this.LeftContainer.Children.Add(rect);
        }

        private void RightButton_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect.Height = 40;
            rect.Width = 350;
            rect.Fill = Brushes.Red;
            rect.Margin = new Thickness(0, 5, 0, 0);
            this.RightContainer.Children.Add(rect);
        }
    }
}
