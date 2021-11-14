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

namespace Samochody
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public float suma_kosztow = 0;
        //public float suma_silnik = 0;
        //public float suma_marka = 0;

        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void marka_Click(object sender, RoutedEventArgs e)
        {
            Marka marka_window = new Marka(this);
            marka_window.Show();
            
            //suma_kosztow = marka_window.koszta + marka_window.cena_polisy;
            //licznik.Content = suma_kosztow;
        }

        private void silnik_Click(object sender, RoutedEventArgs e)
        {
            Silnik silnik_window = new Silnik(this);
            silnik_window.Show();
            
            //suma_kosztow = silnik_window.koszta + silnik_window.moc_silnika;
            //licznik.Content = suma_kosztow;

        }

        public static class FinalPrice
        {
            public static double silnikPrice { get; set; }
            public static double markaPrice { get; set; }
        }

    }
}
