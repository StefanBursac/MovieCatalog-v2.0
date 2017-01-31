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

namespace sadas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            textBox.Text = "Cao";
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {   textBox.FontSize = 50;
            
            textBox.Text = "Stefan";     
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("");
            foreach (var s in textBox.Text)
            {
                textBox.Text = "Stefan";
                radioButton.IsChecked = true;
                if (radioButton.IsChecked == true)
                {
                    textBox.Width = 200;
                }
                else
                {
                    textBox.Width = 1;
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            checkBox.IsChecked = false;
            textBox.FontSize = 40;
            textBox.Text = "Pozz";
            radioButton.IsChecked = false;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
    }
}
