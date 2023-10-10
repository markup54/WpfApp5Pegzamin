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

namespace WpfApp5pegzamin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public String obraztxt = "list.png";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SprawdzCeneClick(object sender, RoutedEventArgs e)
        {
            if(list.IsChecked == true)
            {
                cenatxt.Text = "Cena 1 zł";
                obraztxt = "list.png";
                obraz.Source = new BitmapImage(new Uri("list.png", UriKind.Relative));
            }
            if (paczka.IsChecked == true)
            {
                cenatxt.Text = "Cena 10 zł";
                obraztxt = "paczka.png";
                obraz.Source = new BitmapImage(new Uri("paczka.png", UriKind.Relative));
            }
            if (pocztowka.IsChecked == true)
            {
                cenatxt.Text = "Cena 1.5 zł";
                obraztxt = "pocztowka.png";
                obraz.Source = new BitmapImage(new Uri("pocztowka.png", UriKind.Relative));
            }
        }
    }
}
