using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMssionApp
{
    public class Books
    {
      public Books(string _nameBook, string _nameWrites, int _pages)
        {
            this.NameBook = _nameBook;
            this.NameWrites = _nameWrites;
            this.Pages = _pages;
        }
        Books() { }
       public string NameBook { get; set; }
       public string NameWrites { get; set; }
       public int Pages { get; set; }
    }
}
