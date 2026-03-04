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
    /// Interaction logic for UpdateAuthors.xaml
    /// </summary>
    public partial class UpdateAuthors : Page
    {
        Read read = new Read();
        public UpdateAuthors()
        {
            InitializeComponent();
            var authors = read.ReadAuthors();
            authorCombobox.SelectedValue = authors[0].AuthorName;
            foreach (var auth in authors) 
            {
                authorCombobox.Items.Add(auth.AuthorName);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var authors = read.ReadAuthors();
            var author = authors.FirstOrDefault(x => x.AuthorName == authorCombobox.Text);
            MessageBox.Show(author.AuthorId.ToString());

        }
    }
}
