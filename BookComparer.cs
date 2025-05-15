using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_practicum
{
    class BookComparer : IComparer<Book>
    {
        private Func<Book, Book, int> compareFunc;

        public BookComparer(Func<Book, Book, int> compareFunc)
        {
            this.compareFunc = compareFunc;
        }

        public int Compare(Book x, Book y)
        {
            return compareFunc(x, y);
        }
    }
}
