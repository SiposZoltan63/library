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
    /// Interaction logic for DeleteBooks.xaml
    /// </summary>
    public partial class DeleteBooks : Page
    {
        Read read = new Read();
        Delete delete = new Delete();
        public DeleteBooks()
        {
            InitializeComponent();
            dataGrid3.ItemsSource = read.ReadBooks();
        }
        private void dataGrid2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var record = dataGrid3.CurrentItem as Books;

            var Result = MessageBox.Show($"Biztos törlöd {record.Title} adatait?", "Könyv törlés", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (Result == MessageBoxResult.Yes)
            {
                var book = delete.DeleteBook(record.BookId) as LibraryResults;
                MessageBox.Show(book.Message);
                dataGrid3.ItemsSource = read.ReadBooks();
            }
        }

        private void dataGrid2_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyType.IsClass && e.PropertyType != typeof(string))
            {
                e.Cancel = true;
            }
        }
    }
}
