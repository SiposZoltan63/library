using LibraryGUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI.Datas
{
    internal class Update
    {
        LibraryResults libraryResults = new LibraryResults();
        public object UpdateAuthors(int id, Authors authors)
        {
            using (var context = new librarydbContext())
            {
                var extendedAuthor = context.Authors.Find(id);
                if (extendedAuthor != null) 
                {
                    extendedAuthor.AuthorName = authors.AuthorName;
                    context.Authors.Update(extendedAuthor);
                    context.SaveChanges();
                    libraryResults.Message = "Sikeres módosítás.";
                    libraryResults.Result = extendedAuthor;
                    return libraryResults;
                }
                libraryResults.Message = "Sikertelen módosítás.";
                libraryResults.Result = extendedAuthor;
                return libraryResults;
            }
        }
    }
}
