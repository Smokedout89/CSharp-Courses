﻿using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private readonly List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }

            public bool MoveNext() => ++currentIndex < this.books.Count;

            public void Reset() => this.currentIndex = -1;

            public Book Current => this.books[this.currentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose(){}
        }
    }
}
