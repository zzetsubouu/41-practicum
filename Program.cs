using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_practicum
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("\nВыберите нужное Вам действие:");
                Console.WriteLine("1. Добавить книгу;");
                Console.WriteLine("2. Вывести все книги;");
                Console.WriteLine("3. Сортировать книги по автору;");
                Console.WriteLine("4. Сортировать книги по названию;");
                Console.WriteLine("5. Сортировать книги по издательству;");
                Console.WriteLine("6. Сортировать книги по жанру;");
                Console.WriteLine("7. Выход.");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        library.AddNewBook(Book.CreateBook());
                        break;
                    case 2:
                        library.GetAllBooks();
                        break;
                    case 3:
                        library.SortByAuthor();
                        Console.WriteLine("Книги отсортированы по автору.");
                        break;
                    case 4:
                        library.SortByTitle();
                        Console.WriteLine("Книги отсортированы по названию.");
                        break;
                    case 5:
                        library.SortByPublishing();
                        Console.WriteLine("Книги отсортированы по издательству.");
                        break;
                    case 6:
                        library.SortByGenre();
                        Console.WriteLine("Книги отсортированы по жанру.");
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Неверный ввод.");
                        break;
                }
            }
        }
    }
}
