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

namespace Zadanie3_pw
{
    /// <summary>
    /// Logika interakcji dla klasy Add_window.xaml
    /// </summary>
    public partial class Add_window : Window
    {
        public string new_name = "name";
        public string new_count = "";
        public Add_window()
        {
            InitializeComponent();
            
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = e.Source as TextBox;
            new_name = textBox.Text;
        }

        private void count_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = e.Source as TextBox;
            new_count = textBox.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).AddUser(new_name, new_count);
        }
    }
}




