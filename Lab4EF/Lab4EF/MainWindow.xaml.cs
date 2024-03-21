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

namespace Lab4EF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bibliotekaEntities context = new bibliotekaEntities();
        public MainWindow()
        {
            InitializeComponent();
            BooksDgr.ItemsSource = context.Books.ToList();
            AuthorsCbx.ItemsSource = context.Authors.ToList();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           BooksDgr.ItemsSource = context.Books.ToList().Where(item => item.Title.Contains(SearchTxt.Text));
        }

        private void AuthorsCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AuthorsCbx.SelectedItem != null)
            {
                var selected = AuthorsCbx.SelectedItem as Authors;
                BooksDgr.ItemsSource = context.Books.ToList().Where(item => item.Authors == selected);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BooksDgr.ItemsSource = context.Books.ToList();
        }
    }
}
