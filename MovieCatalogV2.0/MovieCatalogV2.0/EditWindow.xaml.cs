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

namespace MovieCatalogV20
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public Movie movie { get; set; }
       
        public EditWindow(Movie m)wqewq
        {
            InitializeComponent();
            movie = m;
            textboxGenre.ItemsSource = Enum.GetValues(typeof(Movie.Genre));
            textBoxName.Text = m.MovieName;
            textBoxDirector.Text = m.MovieDirector;
            textBoxDate.SelectedDate = m.ReleaseDate;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            movie.MovieName = textBoxName.Text;
            movie.MovieDirector = textBoxDirector.Text;
            movie.ReleaseDate = textBoxDate.SelectedDate;
            movie.MovieGenre = (Movie.Genre)textboxGenre.SelectedItem;
            movie.MovieGenre.ToString();
            this.DialogResult = true;
            this.Close();
        }
    }
}
