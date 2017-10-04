using System;

public class Smartphone : ICallable, IBrowseble
{
    public string Browse(string url)
    {
        var isValid = true;
        foreach (var symb in url)
        {
            if (char.IsDigit(symb))
            {
                isValid = false;
            }
        }

        if (isValid)
        {
            return $"Browsing: {url}!";
        }
        else
        {
            return "Invalid URL!";
        }
    }

    public string Call(string number)
    {
        var isValid = true;
        foreach (var symb in number)
        {
            if (!char.IsDigit(symb))
            {
                isValid = false;
            }
        }

        if (isValid)
        {
            return $"Calling... {number}";
        }
        else
        {
            return "Invalid number!";
        }
    }
}

