using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemModel
{
    public class Dvd : LibraryItem
    {
        public int DurationInMinutes { get; set; }

        public Dvd(string title, string author, int publicationYear, int durationInMinutes)
            : base(title, author, publicationYear)
        {
            DurationInMinutes = durationInMinutes;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Duration: {DurationInMinutes} minutes");
        }

    }
}
