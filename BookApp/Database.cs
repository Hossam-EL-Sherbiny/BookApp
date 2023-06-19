using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace BookApp
{
    public class Database
    {
        private List<Book> books;
        public Database()
        {
            // Initialize the books list as a new empty list.
            books = new List<Book>();
        }

        public void AddBook(Book addBook)
        {
            addBook.Id = GetNextId();
            books.Add(addBook); // adds the book to the books list.
        }

        public void UpdateBook(Book update)
        {
            Book existingBook = books.FirstOrDefault(b => b.Id == update.Id);
            if (existingBook != null)
            {
                existingBook.Title = update.Title;
                existingBook.Author = update.Author;
                existingBook.Year = update.Year;
            }
        }

        public void DeleteBook(int id)
        {
            Book deleteBook = books.FirstOrDefault(b => id == id);
            if (deleteBook != null) 
                books.Remove(deleteBook);
        }

        public Book GetBook(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        private int GetNextId()
        {
            return books.Count > 0 ? books.Max(b => b.Id) + 1 : 1;
        }
    }
}
