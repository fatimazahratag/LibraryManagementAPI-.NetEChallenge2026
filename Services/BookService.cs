using LibraryManagementAPI.Models;
using LibraryManagementAPI.DAL;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementAPI.Services
{
    public class BookService
    {
        private int _nextId = Data.Books.Max(b => b.Id) + 1;

        public List<Book> GetAll() => Data.Books;

        public Book? GetById(int id) => Data.Books.FirstOrDefault(b => b.Id == id);

        public List<Book> GetByTitle(string title) =>
            Data.Books.Where(b => b.Title.Contains(title, System.StringComparison.OrdinalIgnoreCase)).ToList();

        public Book Add(Book book)
        {
            book.Id = _nextId++;
            Data.Books.Add(book);
            return book;
        }

        public bool Update(int id, Book updated)
        {
            var book = GetById(id);
            if (book == null) return false;

            book.Title = updated.Title;
            book.Author = updated.Author;
            book.ISBN = updated.ISBN;
            book.CopiesAvailable = updated.CopiesAvailable;
            book.Price = updated.Price;
            book.PublicationYear = updated.PublicationYear;
            return true;
        }


        public bool Delete(int id)
        {
            var book = GetById(id);
            if (book == null) return false;

            Data.Books.Remove(book);
            return true;
        }
    }
}
