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
        public AddDialogWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var mcc = new MovieCatalogContext())
            {
                Movie m = new Movie() { MovieName = textBoxName.Text, MovieDirector = textBoxDirector.Text, ReleaseDate = textBoxDate.SelectedDate};
                mcc.Movies.Add(m);
                mcc.SaveChanges();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
