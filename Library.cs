using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_practicum
{
    class Library
    {
        private List<Book> books = new List<Book>();
        public void AddNewBook(Book book) => books.Add(book);
        public void GetAllBooks()
        {
            Console.Clear();
            Console.WriteLine("Книги:");
            foreach (var b in books) b.PrintInfo();
        }
        public void SortBooks(Func<Book, Book, int> compareDelegate)
        {
            var sortedBooks = books.OrderBy(b => b, new BookComparer(compareDelegate)).ToList();
            books = sortedBooks;
        }
        public void SortByAuthor()
        {
            SortBooks((b1, b2) => string.Compare(b1.Author, b2.Author, StringComparison.Ordinal));
        }

        public void SortByTitle()
        {
            SortBooks((b1, b2) => string.Compare(b1.Title, b2.Title, StringComparison.Ordinal));
        }

        public void SortByPublishing()
        {
            SortBooks((b1, b2) => string.Compare(b1.Publishing, b2.Publishing, StringComparison.Ordinal));
        }

        public void SortByGenre()
        {
            SortBooks((b1, b2) => string.Compare(b1.Genre, b2.Genre, StringComparison.Ordinal));
        }
    }
}
