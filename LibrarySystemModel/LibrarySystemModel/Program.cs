using LibrarySystemModel;

namespace LibrarySystemModel;

public class Program
{
    public static void Main(string[] args)
    {
        /*
        Define a base class LibraryItem with properties like Title, Author, PublicationYear, and a virtual method DisplayDetails().
        Create derived classes Book (with an ISBN property) and DVD (with a DurationInMinutes property). Override DisplayDetails() in each derived class to include specific information.
        Create a LibraryMember class with properties MemberId, Name, and a method BorrowItem(LibraryItem item).
        Instantiate several Book and DVD objects, and a LibraryMember object. Demonstrate borrowing items and displaying their details. 
        */

        // 1. Instantiate library items
        var book1 = new Book("Book1", "Niko", 2025, "978 - 0137517112");
        var book2 = new Book("Clean Code", "Robert C. Martin", 2008, "978-0132350884");
        var dvd1 = new Dvd("Inception", "Christopher Nolan", 2010, 148);

        // 2. Instantiate a library member
        var member1 = new LibraryMember(1, "Nika");


        // 3. Demonstrate borrowing items
        Console.WriteLine("--- Borrowing Process ---");
        member1.BorrowerItem(book1);
        member1.BorrowerItem(book2);
        member1.BorrowerItem(dvd1);
    }
}