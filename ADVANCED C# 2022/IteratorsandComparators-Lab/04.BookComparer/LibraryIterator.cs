using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class LibraryIterator : IEnumerator<Book>
    {

        private readonly List<Book> books;
        private int index;

        public LibraryIterator(IEnumerable<Book> books)
        {

            this.books = new List<Book>(books);
            this.index = -1;
            this.books.Sort(new BookComparator());
        }


        public Book Current => this.books[this.index];

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            this.index++;
            return this.index < books.Count;
        }

        public void Reset()
        {

        }
    }
}
