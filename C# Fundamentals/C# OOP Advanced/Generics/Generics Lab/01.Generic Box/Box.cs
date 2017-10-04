using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class Box<T>
    where T: IComparable
{
    private List<T> values;

    public Box()
    {
        this.values = new List<T>();
    }

    public IReadOnlyList<T> Values { get => this.values as IReadOnlyList<T>; }

    public void Add(T element)
    {
        this.values.Add(element);
    }

    public void Remove(T element)
    {
        this.values.Remove(element);
    }

    public bool Containts(T element)
    {
        return this.values.Contains(element);
    }

    public T Max()
    {
        return this.values.Max();
    }

    public T Min()
    {
        return this.values.Min();
    }

    public int CountGreaterThan(T comparer)
    {
        return this.Values.Where(v => v.CompareTo(comparer) > 0).ToArray().Length;
    }

    public void Swap(int index1, int index2)
    {
        var firstElement = values[index1];
        values[index1] = values[index2];
        values[index2] = firstElement;
    }

    public void Sort()
    {
        this.values = Sorter<T>.Sort(this.values);
    }

    public string Print()
    {
        var sb = new StringBuilder();
        this.values.ForEach(v => sb.AppendLine(v.ToString()));

        return sb.ToString().Trim();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var item in values)
        {
            sb.AppendLine($"{this.GetType().GetTypeInfo().GenericTypeArguments[0]}: {item}");
        }

        return sb.ToString().Trim();
    }
}