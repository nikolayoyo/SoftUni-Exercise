using System.Collections.Generic;
using System.Linq;

public class Book
{
    private string title;
    private int year;
    private readonly IList<string> authors;

    public Book(string title, int year, params string[] authors)
    {
        this.authors = authors.ToList();
        this.title = title;
        this.year = year;
    }

    public int Year
    {
        get { return this.year; }
        set { this.year = value; }
    }

    public string Title
    {
        get { return this.title; }
        set { this.title = value; }
    }

    
}

