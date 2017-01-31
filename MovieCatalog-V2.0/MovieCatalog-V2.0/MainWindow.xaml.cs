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

namespace MovieCatalog_V2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (var mctx = new MovieCatalogContext())  
            {
              //Movie mov = new Movie() { MovieName = "New Movie" };

              //   mctx.Movies.Add(mov);
              //   mctx.SaveChanges();
           }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            // using (var mctx = new MovieCatalogContext())
            //
               // MovieCatalogContext mtcx = new MovieCatalogContext();
               // Movie mov = new Movie() { MovieName = "Martian", Director="Ridley Scot"};
               // mtcx.Movies.Add(mov);
              //  mtcx.SaveChanges();
                
          //  }
        }
    }
}
