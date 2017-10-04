using System.Collections.Generic;
using System.Linq;

class StackOfStrings
{
    private List<string> date;

    public IReadOnlyCollection<string> Date
    {
        get { return this.date; }
    }

    public void Push(string toPush)
    {
        this.date.Add(toPush);
    }

    public string Pop()
    {
        var popped = this.date.Last();
        this.date.Remove(date.Last());
        return this.date.Last();
    }

    public string Peek()
    {
        return this.date.Last();
    }

    public bool IsEmpty()
    {
        return this.date.Count == 0;
    }
}

