using LibraryGUI.Datas;
using System.Windows;
using System.Windows.Controls;


namespace LibraryGUI.Views
{
    /// <summary>
    /// Interaction logic for ShowDatas.xaml
    /// </summary>
    public partial class ShowDatas : Page
    {
        Read read = new Read();
        private readonly MainWindow _mainWindow;
        public ShowDatas(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;

        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            var list = read.ReadAuthors();
            dataGrid1.ItemsSource = list;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var list = read.ReadCategories();
            dataGrid1.ItemsSource = list;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            var list = read.ReadBooks();
            dataGrid1.ItemsSource = list;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            var list = read.ReadAuthorsWithBooks();
            dataGrid1.ItemsSource = list;
        }
    }
}