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
        CreateAuthors createAuthors = new CreateAuthors();
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
        private void CreateAuthorsMenu(object sender, RoutedEventArgs e)
        {
            _mainWindow.MainPage.Navigate(new CreateAuthors());
        }
        private void CreateBooksMenu(object sender, RoutedEventArgs e)
        {
            _mainWindow.MainPage.Navigate(new CreateBooks());
        }
        private void CreateCategoriesMenu(object sender, RoutedEventArgs e)
        {
            _mainWindow.MainPage.Navigate(new CreateCategories());
        }
        private void DeleteAuthorMenu(object sender, RoutedEventArgs e)
        {
            _mainWindow.MainPage.Navigate(new DeleteAuthor());
        }
        private void DeleteBookMenu(object sender, RoutedEventArgs e)
        {
            _mainWindow.MainPage.Navigate(new DeleteBooks());
        }
        private void DeleteCategoriesMenu(object sender, RoutedEventArgs e)
        {
            _mainWindow.MainPage.Navigate(new DeleteCategories());
        }
        private void UpdateAuthorsMenu(object sender, RoutedEventArgs e)
        {
            _mainWindow.MainPage.Navigate(new UpdateAuthors());
        }
        private void UpdateBooksMenu(object sender, RoutedEventArgs e)
        {
            _mainWindow.MainPage.Navigate(new UpdateBooks());
        }
        private void UpdateCategoriesMenu(object sender, RoutedEventArgs e)
        {
            _mainWindow.MainPage.Navigate(new UpdateCategories());
        }
    }
}