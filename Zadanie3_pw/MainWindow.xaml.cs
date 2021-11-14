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
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;

namespace Zadanie3_pw
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<user> items = new List<user>();
       
        public MainWindow()
        {
            InitializeComponent();
            listView.ItemsSource = items;

        }

        public class user
        {
            public string name { get; set; }

            public string id { get; set; }

            public int count { get; set; }
        }



        public void AddUser(string name, string cnt)
        {
            int index = items.Count + 1;
            items.Add(new user() { name = name, id = index.ToString(), count = Int32.Parse(cnt) });
            listView.Items.Refresh();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Add_window add_Window = new Add_window();
            add_Window.Show();
        }


        

        private void zapis_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog new_file = new SaveFileDialog();
            new_file.Filter = "CSV file (*.csv)|Text file (*.txt)|*.txt|*.csv|All files (*.*)|*.*";

            new_file.ShowDialog();
            string savePathCSV = new_file.FileName;

            using (var output = new StreamWriter(savePathCSV))
            {
                foreach (user item in listView.Items)
                {
                    output.WriteLine("{0};{1};{2}", item.name, item.id, item.count);
                }
            }
        }

        private void odczyt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {

                items.Clear();
                foreach (string line in File.ReadLines(openFileDialog.FileName))
                {
                    string[] args = line.Split(',');
                    AddUser(args[0], args[2]);
                }
            }
        }
    }
}
    





