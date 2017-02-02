using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MovieCatalogV20
{
    /// <summary>
    /// Interaction logic for AddDialogWindow.xaml
    /// </summary>
    public partial class AddDialogWindow : Window
    {
       public Movie movie { get; set; }
        
        public AddDialogWindow()
        {
            InitializeComponent();
            textboxGenre.ItemsSource = Enum.GetValues(typeof(Movie.Genre));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            movie = new Movie();
            movie.MovieName = textBoxName.Text;
            movie.MovieDirector = textBoxDirector.Text;
            movie.MovieGenre = (Movie.Genre)(textboxGenre.SelectedItem);
            movie.ReleaseDate = textBoxDate.SelectedDate;
            this.DialogResult = true;
            this.Close();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
