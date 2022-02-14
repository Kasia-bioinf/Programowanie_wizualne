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

namespace lab12
{
    /// <summary>
    /// Logika interakcji dla klasy SumW.xaml
    /// </summary>
    public partial class SumW : Window
    {
        int animal = -1;
        int level = -1;
        Buttons btnWindow;

        public SumW(Buttons buttons, string result)
        {
            InitializeComponent();

            animal = buttons.animal;
            level = buttons.level;
            btnWindow = buttons;

            if (result == "win")
            {
                message.Text = "You caught " + buttons.animals[animal].Name + "!";
                tryAgain.Visibility = Visibility.Collapsed;
                returnButton.Margin = tryAgain.Margin;
            }
            else if (result == "wasted")
            {
                message.Text = "Wasted...";
            }
            else
            {
                message.Text = "You died...";
                tryAgain.Visibility = Visibility.Collapsed;
                returnButton.Margin = tryAgain.Margin;
            }
        }

        private void tryAgain_Click(object sender, RoutedEventArgs e)
        {
            btnWindow.Close();
            Buttons buttons = new Buttons(animal, level);
            buttons.Show();
            this.Close();
        }

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            btnWindow.Close();
            this.Close();
        }
    }
}
