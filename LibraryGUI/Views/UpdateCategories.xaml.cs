using LibraryGUI.Datas;
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
    /// Interaction logic for UpdateCategories.xaml
    /// </summary>
    public partial class UpdateCategories : Page
    {
        Read read = new Read();
        public UpdateCategories()
        {
            InitializeComponent();
            var categories = read.ReadCategories();
            CategoriesComboBox.SelectedValue = categories[0].CategoryName;
            foreach (var cate in categories)
            {
                CategoriesComboBox.Items.Add(cate.CategoryName);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var categories = read.ReadCategories();
            var categorie = categories.FirstOrDefault(x => x.CategoryName == CategoriesComboBox.Text);
            MessageBox.Show(categorie.CategoryId.ToString());
        }
    }
}
