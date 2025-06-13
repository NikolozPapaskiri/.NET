using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemModel
{
    public class Book : LibraryItem
    {
        public string ISBN { get; set; }

        public Book(string title, string author, int publicationYear, string isbn) 
            : base(title, author, publicationYear)
        {
            ISBN = isbn;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }
}
