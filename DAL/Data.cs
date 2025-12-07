using LibraryManagementAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;

namespace LibraryManagementAPI.DAL
{
    public class Data
    {
        public static List<Book> Books = new List<Book>
        {
        new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", ISBN = "9780743273565", CopiesAvailable = 5, Price = 10.99, PublicationYear = 1925 },
        new Book { Id = 2, Title = "To Kill a Mockingbird ", Author = "Harper Lee", ISBN = "9780061120084", CopiesAvailable = 3, Price = 7.99, PublicationYear = 1960 },
        new Book { Id = 3, Title = "1984", Author = "George Orwell", ISBN = "9780451524935", CopiesAvailable = 4, Price = 8.99, PublicationYear = 1949 },
        new Book { Id = 4, Title = "Pride and Prejudice", Author = "Jane Austen", ISBN = "9780141439518", CopiesAvailable = 2, Price = 6.99, PublicationYear = 1813 },
        new Book { Id = 5, Title = "The Catcher in the Rye", Author = "J.D. Salinger", ISBN = "9780316769488", CopiesAvailable = 6, Price = 9.99, PublicationYear = 1951 }
            };
    }

   
}

