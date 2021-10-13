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
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            zegar_1.Content = DateTime.Now.ToLongTimeString();
            DateTime myDateTime = DateTime.Now;


            TimeSpan TimeSpan_2 = new TimeSpan(1, 0, 0);
            DateTime myDateTime2 = myDateTime - TimeSpan_2;
            zegar_2.Content = myDateTime2.ToString("HH:mm:ss");

            TimeSpan TimeSpan_3 = new TimeSpan(6, 0, 0);
            DateTime myDateTime3 = myDateTime + TimeSpan_3;
            zegar_3.Content = myDateTime3.ToString("HH:mm:ss");
            
        }



        private void stoper_Click(object sender, RoutedEventArgs e)
        {
            okno_stopera okno_Stopera = new okno_stopera();
            okno_Stopera.Show();
        }
    }
}
