namespace SingleResponsibility
{
    // A class that just manages a book's information.
    public class Book
    {
        public string? Title { get; set; }
        public string? Author { get; set; }

        public void PrintTitle()
        {
            Console.WriteLine(Title);
        }
    }

    // A separate class for printing books, not mixing with the Book class.
    public class BookPrinter
    {
        public static void Print(Book book)
        {
            Console.WriteLine($"Printing book: {book.Title} by {book.Author}");
        }
    }
}
