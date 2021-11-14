using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Samochody
{
    /// <summary>
    /// Logika interakcji dla klasy Silnik.xaml
    /// </summary>
    public partial class Silnik : Window
    {
        
        public double koszta = 0;
        public double moc_silnika = 0;

        MainWindow mainW;
        public Silnik(MainWindow window)
        {
            InitializeComponent();
            mainW = window;
            koszta = MainWindow.FinalPrice.silnikPrice;
            MainWindow.FinalPrice.silnikPrice = 0;
            cena_silnik.Content = koszta;
        }

        private void button_powrót_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.FinalPrice.silnikPrice = koszta + moc_silnika;
            mainW.licznik.Content = MainWindow.FinalPrice.markaPrice + MainWindow.FinalPrice.silnikPrice;
            this.Close();
        }

        private void rbutton_benzyna_Checked(object sender, RoutedEventArgs e)
        {
            if (rbutton_benzyna.IsChecked == true)
                koszta = koszta + 2000;
            else
                koszta = koszta - 2000;
            cena_silnik.Content = koszta + moc_silnika;
        }

        private void rbutton_diesel_Checked(object sender, RoutedEventArgs e)
        {
            if (rbutton_diesel.IsChecked == true)
                koszta = koszta + 3000;
            else
                koszta = koszta - 3000;
            cena_silnik.Content = koszta + moc_silnika;
        }

        private void rbutton_gaz_Checked(object sender, RoutedEventArgs e)
        {
            if (rbutton_gaz.IsChecked == true)
                koszta = koszta + 1000;
            else
                koszta = koszta - 1000;
            cena_silnik.Content = koszta +  moc_silnika;
        }

        private void rbutton_hybryda_Checked(object sender, RoutedEventArgs e)
        {
            if (rbutton_hybryda.IsChecked == true)
                koszta = koszta + 5000;
            else
                koszta = koszta - 5000;
            cena_silnik.Content = koszta + moc_silnika;
        }

        private void moc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (moc.SelectedIndex == 0)
            {
                moc_silnika = 1000;
            }
            if (moc.SelectedIndex == 1)
            {
                moc_silnika = 2000;
            }
            if (moc.SelectedIndex == 2)
            {
                moc_silnika = 3000;
            }
            if (moc.SelectedIndex == 3)
            {
                moc_silnika = 4000;
            }
            cena_silnik.Content = koszta + moc_silnika;
        }
    }
}
