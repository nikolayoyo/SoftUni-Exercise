using System;
using System.Collections.Generic;
using System.Linq;

public static class Sorter<T> 
    where T: IComparable
{
    public static List<T> Sort(List<T> list)
    {
        return list.OrderBy(v => v).ToList();
    }
}
