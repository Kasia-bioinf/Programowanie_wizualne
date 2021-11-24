using System;
using System.Configuration;
using System.Collections.Specialized;
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
using Microsoft.Win32;
using System.Xml.Serialization;
using System.Text.RegularExpressions;
using System.Reflection;


namespace Zadanie3_pw
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<user> items = new List<user>();
        string lastLocation = "";
        public List<user> tmpitems = new List<user>();
        public List<user> searchedItems = new List<user>();
        

        public MainWindow()
        {
            InitializeComponent();
            listView.ItemsSource = items;
            if (ConfigurationManager.AppSettings.Get("lastLocation") != "")
            {
                if (File.Exists(ConfigurationManager.AppSettings.Get("lastLocation")))
                {
                    odczyt_file(ConfigurationManager.AppSettings.Get("lastLocation"));
                }
            }
            else
            {
                lastLocation = "";
            }

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
            if (new_file.ShowDialog() == true)
            {
                SerializeToXml(items, new_file.FileName.Split('.')[0] + ".xml");
            }
        }


       

        private void odczyt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == true)
            {
                lastLocation = openFile.FileName;
                odczyt_file(lastLocation);
            }
        }

        void odczyt_file(string filename)
        {
            items.Clear();
            tmpitems = DeserializeToObject<List<user>>(filename);
            foreach (user el in tmpitems)
            {
                AddUser(el.name, el.count.ToString());
            }

            /*Configuration configuration = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            configuration.AppSettings.Settings["lastLocation"].Value = filename;
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");*/
        }

        public static void SerializeToXml<T>(T anyobject, string xmlFilePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(anyobject.GetType());

            using (StreamWriter writer = new StreamWriter(xmlFilePath))
            {
                xmlSerializer.Serialize(writer, anyobject);
            }
        }

        public T DeserializeToObject<T>(string filepath) where T : class
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            using (StreamReader sr = new StreamReader(filepath))
            {
                return (T)serializer.Deserialize(sr);
            }
        }


        /*private void Dialog_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want save changes?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = false;
            }
            else if (result == MessageBoxResult.Yes)
            {
                zapis.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
        }*/

       


        private void sort_name_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sort_count_Click(object sender, RoutedEventArgs e)
        {

        }

        private void wyszukiwanie_Click(object sender, RoutedEventArgs e)
        {

            
            string searchText = tekst_search.Text;
            if (Regex.IsMatch(searchText, @"^[0-9]+$"))
            {
                int searchNumber = int.Parse(searchText);
                List<user> filteredItems = new List<user>();
                foreach (user listRow in listView.ItemsSource)
                {
                    if (listRow.count == searchNumber)
                        filteredItems.Add(listRow);
                }
                listView.ItemsSource = filteredItems;
            }
            else if (Regex.IsMatch(searchText, @"^[a-zA-Z]+$"))
            {
                List<user> filteredItems = new List<user>();
                foreach (user listRow in listView.ItemsSource)
                {
                    if (listRow.name == searchText)
                        filteredItems.Add(listRow);
                }
                listView.ItemsSource = filteredItems;
            }
            else if (searchText != "")
            {
                MessageBox.Show("Tekst do wyszukiwania musi zawierać tylko litery lub tylko cyfry!", "Błąd wyszukiwania",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        /* void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
         {
             if (items.Count() > 0)
             {
                 AreYouSure popupWindow = new AreYouSure();
                 popupWindow.ShowDialog();
                 e.Cancel = true;
             }
         }*/

        
    }
}
    





