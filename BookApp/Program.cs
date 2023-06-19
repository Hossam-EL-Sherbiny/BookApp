// See https://aka.ms/new-console-template for more information
using BookApp;

Database db = new Database();

// Add some books to the database..
db.AddBook(new Book { Title = "To Kill a Mockingbrid", Author = "Harper Lee", Year = 1960});
db.AddBook(new Book { Title = "1984", Author = "George Orwell", Year = 1949 });
db.AddBook(new Book { Title = "Pride and Prejudice", Author = "Jane Austen", Year = 1813 });


Book book = db.GetBook(2);
if (book != null)
{
    Console.WriteLine("Book details: ");
    Console.WriteLine($"ID: {book.Id}");
    Console.WriteLine($"Title: {book.Title}");
    Console.WriteLine($"Author: {book.Author}");
    Console.WriteLine($"Year: {book.Year}");

    Book bookToUpdate = db.GetBook(3);
    if (bookToUpdate != null)
    {
        bookToUpdate.Title = "Sense and Sensibility";
        bookToUpdate.Author = "ane Austen";
        bookToUpdate.Year = 1811;

        db.UpdateBook(bookToUpdate);
        Console.WriteLine("Updated Book details: ");
        Console.WriteLine($"ID: {bookToUpdate.Id}");
        Console.WriteLine($"Title: {bookToUpdate.Title}");
        Console.WriteLine($"Author: {bookToUpdate.Author}");
        Console.WriteLine($"Year: {bookToUpdate.Year}");
    }

    // Delete a book and print the remaining books
    db.DeleteBook(1);

    Console.WriteLine("Remaining books:");
    List<Book> allBooks = db.GetAllBooks();
    foreach (Book b in allBooks)
    {
        Console.WriteLine($"ID: {b.Id}, Title: {b.Title}, Author: {b.Author}, Year: {b.Year}");
    }

    Console.ReadKey();
}
