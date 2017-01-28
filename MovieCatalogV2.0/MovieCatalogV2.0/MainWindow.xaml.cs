﻿using System;
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

namespace MovieCatalogV2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
       public MovieCatalogContext m = new MovieCatalogContext();
       MovieCollection ms = new MovieCollection();
        public MainWindow()
        {
            InitializeComponent();
            
            //foreach (Movie ma in m.Movies)
            //{
            //    ms.movie.Add(ma);
            //}
            dataGrid.ItemsSource = m.Movies.ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddDialogWindow addWindow = new AddDialogWindow();
            addWindow.ShowDialog();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            m.Movies.Remove((Movie)dataGrid.SelectedItem);
            dataGrid.Items.Refresh();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            m.SaveChanges();
        }
    }
}
