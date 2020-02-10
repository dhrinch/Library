using System.Collections.Generic;
using System.Linq;

namespace Library
{
    class Library
    {
        List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void AddBook(string title, string authorName, string authorLastName, string text)
        {
            Book book = new Book(title, authorName, authorLastName, text);
            books.Add(book);
        }

        public List<Book> getListByAuthor(string authorLastName)
        {
            return books.Where(book => book.author.lastName == authorLastName).ToList();
        }

        public override string ToString()
        {
            string s = "";
            foreach (Book book in books)
            {
                s += book + "\n";
            }
            return s;
        }
    }
}
