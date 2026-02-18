using LibraryGUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI.Datas
{
    internal class Create
    {
        public object CreateAuthor(string name)
        {
            using (var context = new librarydbContext())
            {
                var author = new Authors
                {
                    AuthorName = name
                };
                context.Authors.Add(author);
                context.SaveChanges();
                return new { message = "Sikeres felvétel", result = author };
            }  
        }
        public object CreateBooks(string name,int Bookauthorid,int BookCategoriesid,DateTime Bookdatepicker)
        {
            using (var context = new librarydbContext())
            {
                var book = new Books
                {
                    Title = name,
                    AuthorId = Bookauthorid,
                    CategoryId = BookCategoriesid,
                    PublishDate = Bookdatepicker
                };
                context.Books.Add(book);
                context.SaveChanges();
                return new { message = "Sikeres felvétel", result = book };
            }
        }
        public object CreateCategories(string name)
        {
            using (var context = new librarydbContext())
            {
                var categories = new Categories
                {
                    CategoryName = name
                };
                context.Categories.Add(categories);
                context.SaveChanges();
                return new { message = "Sikeres felvétel", result = categories };
            }
        }
    }
}
