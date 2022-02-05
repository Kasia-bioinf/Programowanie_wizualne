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

namespace lab7_1
{
    /// <summary>
    /// Logika interakcji dla klasy AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        public string title = "";
        public string author = "";

        public AddBook()
        {
            InitializeComponent();
        }
        private void AddBook_Button_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).AddBook(title, author);
            Close();
        }

        private void title_input_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = e.Source as TextBox;
            title = textBox.Text;
        }

        private void author_input_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = e.Source as TextBox;
            author = textBox.Text;
        }
    }
}
