using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemModel
{
    public class LibraryItem
    {
        public string Title;
        public string Author;
        public int PublicationYear;

        protected LibraryItem(string title, string author, int publicationYear) 
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author/Director: {Author}");
            Console.WriteLine($"Publication Year: {PublicationYear}");
        }

    }
}
