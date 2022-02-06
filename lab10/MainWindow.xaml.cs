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
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using Microsoft.Win32;
using System.Diagnostics;

namespace lab10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool isPlaying, isPaused;
        public OpenFileDialog openFileDialog = new OpenFileDialog();
        public ListBoxItem selectedItm;
        public string directory = "", nowPlaying = "";

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }

        public MainWindow()
        {
            InitializeComponent();
            isPlaying = false;

            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                directory = openFileDialog.FileNames[0];
                directory = directory.Substring(0, directory.LastIndexOf('\\')) + '\\';
                Debug.WriteLine(directory);
                addSongs(openFileDialog.FileNames);

            }
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            
            timer.Start();
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem first = Songs.Items[0] as ListBoxItem;
            Debug.WriteLine(first.Content.ToString());
            if (selectedItm == null)
            {
                mediaPlayer.Open(new Uri($"{directory}{first.Content.ToString()}"));
                nowPlaying = first.Content.ToString();
            }
            else
            {
                mediaPlayer.Open(new Uri($"{directory}{selectedItm.Content.ToString()}"));
                nowPlaying = selectedItm.Content.ToString();
            }
            mediaPlayer.Play();
        }

        private void Songs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            selectedItm = Songs.SelectedItems[0] as ListBoxItem;
            Debug.WriteLine(selectedItm.Content);

        }

        
        private MediaPlayer mediaPlayer = new MediaPlayer();

        private void addSongs(string[] songs)
        {
            foreach (var song in songs)
            {
                ListBoxItem itm = new ListBoxItem();
                itm.Content = song.Split('\\').Last();
                

                Songs.Items.Add(itm);
            }
        }

    }
}
