using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemModel
{
    public class LibraryMember
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        private readonly List<LibraryItem> _borrowedItems = new();

        public LibraryMember(int memberId, string name) 
        {
            MemberId = memberId;
            Name = name;
        }

        public void BorrowerItem(LibraryItem item)
        {
            _borrowedItems.Add(item);
            Console.WriteLine($"{Name} has borrowed '{item.Title}'.");
        }

        public void DisplayBorrowedItems()
        {
            Console.WriteLine($"\n--- Items Borrowed by {Name} ---");
            foreach(var item in _borrowedItems)
            {
                item.DisplayDetails();
                Console.WriteLine("------------------");
            }
        }
    }
}


// Create a LibraryMember class with properties MemberId, Name, and a method BorrowItem(LibraryItem item).