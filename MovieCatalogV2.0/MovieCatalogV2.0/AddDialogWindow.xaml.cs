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

namespace MovieCatalogV2._0
{
    /// <summary>
    /// Interaction logic for AddDialogWindow.xaml
    /// </summary>
    public partial class AddDialogWindow : Window
    {
        Movie m = new Movie();
        
        public AddDialogWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {   
                
                Movie mov = new Movie() { MovieName = textBoxName.Text, MovieDirector = textBoxDirector.Text, ReleaseDate = textBoxDate.SelectedDate.Value};
                
                Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
