using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            this.Books = books.ToList();
        }
        private List<Book> Books { get; set; }

        public IEnumerator<Book> GetEnumerator() => new LibraryIterator(this.Books);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
