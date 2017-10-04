using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Library : IEnumerable<Book>
{
    private readonly List<Book> books;

    public Library(params Book[] books)
    {
        this.books = books.ToList();
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return this.books.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

