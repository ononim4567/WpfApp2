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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
           InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            tanki.Source = new BitmapImage (new Uri(@"C:\avatar.png"));
        }
        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            tanki.Source = new BitmapImage(new Uri(@"C:\самолетики.jpg"));
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            tanki.Source = new BitmapImage(new Uri(@"C:\maxresdefault.jpg"));
        }
    }
}
