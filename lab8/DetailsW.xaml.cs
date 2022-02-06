
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
using static lab8.MainWindow;

namespace lab8
{
    /// <summary>
    /// Logika interakcji dla klasy DetailsW.xaml
    /// </summary>
    public partial class DetailsW : Window
    {
        MainWindow mainWin;
        public DetailsW(MainWindow mainWindow)
        {
            InitializeComponent();
            mainWin = mainWindow;
            int selectedInd = mainWin.airportsList.SelectedIndex;
            Airport selectedAirport = mainWin.allAirports[selectedInd];
            string textToDisplay = "";
            if (mainWin.icaoCode.IsChecked == true)
            {
                textToDisplay += "Kod lotniska ICAO: " + selectedAirport.ICAO + "\n";
            }
            if (mainWin.iataCode.IsChecked == true)
            {
                textToDisplay += "Kod lotniska IATA: " + selectedAirport.IATA + "\n";
            }
            if (mainWin.passengersNumber.IsChecked == true)
            {
                textToDisplay += "Liczba pasażerów: " + selectedAirport.Passengers + "\n";
            }
            if (mainWin.voivodeship.IsChecked == true)
            {
                textToDisplay += "Województwo: " + selectedAirport.Voivodeship + "\n";
            }
            if (mainWin.city.IsChecked == true)
            {
                textToDisplay += "Miasto: " + selectedAirport.City + "\n";
            }

            if (textToDisplay == "")
                textToDisplay = "Nie wybrano, żadnego pola do wyświetlenia.";

            details.Text = textToDisplay;
        }

        private void closeWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
