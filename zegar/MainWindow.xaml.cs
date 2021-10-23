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
using System.Windows.Threading;


namespace zegar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TimeZoneInfo _currentTimeZone;
        public MainWindow()
        {
            InitializeComponent();
            

            try
            {
                _currentTimeZone = TimeZoneInfo.FindSystemTimeZoneById((string)((ComboBoxItem)timezones.SelectedItem).Content);
            }
            catch (Exception _)
            {
                _currentTimeZone = TimeZoneInfo.Utc;
            }

            zegar_1.Content = (TimeZoneInfo.ConvertTime(DateTime.Now, _currentTimeZone)).ToLongTimeString();


            DispatcherTimer dispachterTimer = new DispatcherTimer();
            dispachterTimer.Tick += updateTime;
            dispachterTimer.Interval = new TimeSpan(0, 0, 1);
            dispachterTimer.Start();
        }

        private void updateTime(object sender, EventArgs e)
        {
            zegar_1.Content = (TimeZoneInfo.ConvertTime(DateTime.Now, _currentTimeZone)).ToLongTimeString();
        }

        private void timezoneChange(object sender, EventArgs e)
        {
            try
            {
                _currentTimeZone = TimeZoneInfo.FindSystemTimeZoneById((string)((ComboBoxItem)timezones.SelectedItem).Content);
            }
            catch (Exception _)
            {
                _currentTimeZone = TimeZoneInfo.Utc;
            }
        }

        



        private void stoper_Click(object sender, RoutedEventArgs e)
        {
            okno_stopera okno_Stopera = new okno_stopera();
            okno_Stopera.Show();
        }
    }
}
