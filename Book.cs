using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_practicum
{
    class Book
    {
        private string author;
        private string genre;
        private string title;
        private string publishing;

        public string Author { get => author; set => author = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Title { get => title; set => title = value; }
        public string Publishing { get => publishing; set => publishing = value; }

        public Book(string author, string genre, string title, string publishing)
        {
            Author = author;
            Genre = genre;
            Title = title;
            Publishing = publishing;
        }
        public static Book CreateBook()
        {
            Console.WriteLine("Введите название книги");
            string title = Console.ReadLine();
            Console.WriteLine("Введите автора");
            string author = Console.ReadLine();
            Console.WriteLine("Введите жанр");
            string genre = Console.ReadLine();
            Console.WriteLine("Введите издательство");
            string publishing = Console.ReadLine();

            return new Book(author, genre, title, publishing);
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Книга: Название {Title}, автор {Author}, жанр {Genre}, издательство {Publishing}");
        }
    }
}
