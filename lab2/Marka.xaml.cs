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
    /// Logika interakcji dla klasy Marka.xaml
    /// </summary>
    public partial class Marka : Window
    {
        public int koszta = 0;
        public int cena_polisy = 0;
        
        MainWindow mainW;
        
        public Marka(MainWindow window)
        {
            InitializeComponent();
            mainW = window;
            MainWindow.FinalPrice.markaPrice = 0;
            cena_marka.Content = MainWindow.FinalPrice.silnikPrice;
        }


        private void powrót_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.FinalPrice.markaPrice = koszta + cena_polisy;
            mainW.licznik.Content = MainWindow.FinalPrice.markaPrice + MainWindow.FinalPrice.silnikPrice;
            this.Close();

        }

        private void rbutton_ford_Checked(object sender, RoutedEventArgs e)
        {
            if (rbutton_ford.IsChecked == true)
                koszta = koszta + 2000;
            else
                koszta = koszta - 2000;
            cena_marka.Content = koszta + cena_polisy;
        }

        private void rbutton_ferrari_Checked(object sender, RoutedEventArgs e)
        {
            if(rbutton_ferrari.IsChecked == true)
                koszta = koszta + 5000;
            else
                koszta = koszta - 5000;
            cena_marka.Content = koszta + cena_polisy;
        }

        private void rbutton_fiat_Checked(object sender, RoutedEventArgs e)
        {
            if (rbutton_fiat.IsChecked == true)
                koszta = koszta + 1000;
            else
                koszta = koszta - 1000;
            cena_marka.Content = koszta + cena_polisy;
        }

        private void check_klima_Checked(object sender, RoutedEventArgs e)
        {
            if (check_klima.IsChecked == true)
                koszta = koszta + 500;
            else
                koszta = koszta - 500;
            cena_marka.Content = koszta + cena_polisy;
        }

        private void check_fotele_Checked(object sender, RoutedEventArgs e)
        {
            if (check_fotele.IsChecked == true)
                koszta = koszta + 1500;
            else
                koszta = koszta - 1500;
            cena_marka.Content = koszta + cena_polisy;
        }

        private void check_kierownica_Checked(object sender, RoutedEventArgs e)
        {
            if (check_kierownica.IsChecked == true)
                koszta = koszta + 400;
            else
                koszta = koszta - 400;
            cena_marka.Content = koszta + cena_polisy;
        }

        private void check_radio_Checked(object sender, RoutedEventArgs e)
        {
            if (check_radio.IsChecked == true)
                koszta = koszta + 100;
            else
                koszta = koszta - 100;
            cena_marka.Content = koszta + cena_polisy;
        }

        private void polisa_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(!int.TryParse(polisa.Text, out cena_polisy))
            {
                cena_polisy = 0;
            }
            cena_marka.Content = koszta + cena_polisy;
        }

        

        
    }
}
