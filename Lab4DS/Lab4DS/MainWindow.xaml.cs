using System;
using System.Collections.Generic;
using System.Data;
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
using Lab4DS.bibliotekaDataSetTableAdapters;

namespace Lab4DS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BooksTableAdapter books = new BooksTableAdapter();
        AuthorsTableAdapter authors = new AuthorsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            BooksDrg.ItemsSource = books.GetData();
            AuthorsCbx.ItemsSource = authors.GetData();
            BooksDrg.DisplayMemberPath = "Name";
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BooksDrg.ItemsSource = books.GetDataBy(SearchTxt.Text);
        }

      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BooksDrg.ItemsSource = books.GetData();
        }

        private void AuthorsCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AuthorsCbx.SelectedItem != null)
            {
                var id = (int)(AuthorsCbx.SelectedItem as DataRowView)?.Row[0];
                BooksDrg.ItemsSource = books.GetDataBy1(id);
            }

        }
    }
}
