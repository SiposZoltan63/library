using LibraryGUI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LibraryGUI.Datas
{
    public class Read
    {
        public List<Authors> ReadAuthors()
        {

            using (var context = new librarydbContext())
            {
                var users = context.Authors.ToList();
                return users;
            }
        }

        public List<Categories> ReadCategories()
        {

            using (var context = new librarydbContext())
            {
                var category = context.Categories.ToList();
                return category;
            }
        }

        public List<Books> ReadBooks()
        {

            using (var context = new librarydbContext())
            {
                var book = context.Books.ToList();
                return book;
            }
        }

        public List<Authors> ReadAuthorsWithBooks()
        {

            using (var context = new librarydbContext())
            {
                var book = context.Authors.Include(x => x.Books).ToList();
                var count = book.First().Books.Count;
                MessageBox.Show(count.ToString());
                return book;
            }
        }
    }
}