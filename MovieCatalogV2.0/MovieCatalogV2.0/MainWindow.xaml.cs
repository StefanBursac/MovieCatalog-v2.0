using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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

namespace MovieCatalogV20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Movie> Movies = new ObservableCollection<Movie>();

        public MovieCatalogContext m = new MovieCatalogContext();

        public MainWindow()
        {   
            InitializeComponent();

            Movies = new ObservableCollection<Movie>(m.Movies);
            dataGrid.ItemsSource = Movies;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddDialogWindow addWindow = new AddDialogWindow();
            if (addWindow.ShowDialog() == true)
            {
                Movies.Add(addWindow.movie);
                m.Movies.Add(addWindow.movie);
                dataGrid.Items.Refresh();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;

            result = MessageBox.Show("Are You sure You want to Delete selected Movie", "Delete", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                var selected = (Movie)dataGrid.SelectedItem;
                Movies.Remove(selected);
                m.Movies.Remove(selected);
            }

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            m.SaveChanges();
            MessageBox.Show("Movies saved succsesfully");
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            EditWindow editWindow = new EditWindow((Movie)dataGrid.SelectedItem);

            if (editWindow.ShowDialog() == true)
            {
                m.Movies.Add(editWindow.movie);
                dataGrid.Items.Refresh();
            }
        }
    }
}

