using LibraryGUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI.Datas
{
    internal class Read
    {
        public List<Authors> ReadAuthors() 
        {
			try
			{
				using (var context = new librarydbContext())
				{
					var users = context.Authors.ToList();
					return users;
				}
			}
			catch (Exception)
			{
				return null;
			}
        }
    }
}
