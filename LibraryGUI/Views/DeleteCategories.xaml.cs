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
    /// Interaction logic for DeleteCategories.xaml
    /// </summary>
    public partial class DeleteCategories : Page
    {
        Read read = new Read();
        Delete delete = new Delete();
        public DeleteCategories()
        {
            InitializeComponent();
            dataGrid1.ItemsSource = read.ReadCategories();
        }
        private void dataGrid1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var record = dataGrid1.CurrentItem as Categories;

            var Result = MessageBox.Show($"Biztos törlöd {record.CategoryName} adatait?", "Kategória törlés", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (Result == MessageBoxResult.Yes)
            {
                var category = delete.DeleteCategories(record.CategoryId) as LibraryResults;
                MessageBox.Show(category.Message);
                dataGrid1.ItemsSource = read.ReadCategories();
            }
        }

        private void dataGrid1_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyType.IsClass && e.PropertyType != typeof(string))
            {
                e.Cancel = true;
            }
        }
    }
}
