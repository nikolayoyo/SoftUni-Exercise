using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMoreDic
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var studentsStuff = new SortedDictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var grades = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                if (!studentsStuff.ContainsKey(name))
                {
                    studentsStuff[name] = new List<double>();
                }

                foreach (var grade in grades)
                {
                    studentsStuff[name].Add(grade);
                }
            }

            foreach (var student in studentsStuff)
            {
                var averageGrade = student.Value.Average();
                Console.WriteLine($"{student.Key} is graduated with {averageGrade}");
            }
        }
    }
}
