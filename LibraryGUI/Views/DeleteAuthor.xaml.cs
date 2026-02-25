using LibraryGUI.Datas;
using LibraryGUI.Models;
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

namespace LibraryGUI.Views
{
    /// <summary>
    /// Interaction logic for DeleteAuthor.xaml
    /// </summary>
    public partial class DeleteAuthor : Page
    {
        Read read = new Read();
        public DeleteAuthor()
        {
            InitializeComponent();
        }
        public List<Authors> ReadAuthors()
        {

            using (var context = new librarydbContext())
            {
                var users = context.Authors.ToList();
                return users;
            }
        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            var list = read.ReadAuthors();
            dataGrid2.ItemsSource = list;
        }
        private void dataGrid2_SelectionChanged(object sender, RoutedEventArgs e)
        {
            var record = dataGrid2.CurrentItem as Authors;
            var Result = MessageBox.Show($"Biztos törlöd");
        }
    }
}
