using Microsoft.Win32;
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
using System.IO;

namespace lab5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog seqFile = new OpenFileDialog();

            if (seqFile.ShowDialog() == true)
            {
                string seq = File.ReadAllText(seqFile.FileName);
                string noWhiteSpaces = String.Concat(seq.Where(c => !Char.IsWhiteSpace(c)));
                sekwencja.Text = noWhiteSpaces;
            }
        }

        private void wzorce_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void wzorce_combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public class Algorithm
        {

        }
    }
}
