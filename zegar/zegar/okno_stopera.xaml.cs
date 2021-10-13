using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace zegar
{
    /// <summary>
    /// Logika interakcji dla klasy okno_stopera.xaml
    /// </summary>
    public partial class okno_stopera : Window
    {
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
        DateTime time = new DateTime();



        public okno_stopera()
        {
            InitializeComponent();

            timer.Tick += counter;
            timer.Interval = new TimeSpan(0, 0, 0, 1);

   
        }
        private void counter (object sender, EventArgs e)
        {
            time = time.AddSeconds(1);
            timer_1.Content = time.ToString("HH:mm:ss");
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }
    }
}
