using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departments
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var listOfDeps = new Dictionary<string, List<Employee>>();
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split().ToArray();
                Employee currentEmployer;
                if (inputLine.Length == 6)
                {
                    currentEmployer = new Employee(inputLine[0], double.Parse(inputLine[1]), inputLine[2], inputLine[3], inputLine[4], int.Parse(inputLine[5]));
                }
                else if (inputLine.Length == 5)
                {
                   

                    currentEmployer = new Employee(inputLine[0], double.Parse(inputLine[1]), inputLine[2], inputLine[3]);

                    var emailOrAge = inputLine[4].Contains('@');
                    if (emailOrAge)
                    {
                        currentEmployer.Email = inputLine[4];
                    }
                    else
                    {
                        currentEmployer.Age = int.Parse(inputLine[4]);
                    }

                }
                else
                {
                    currentEmployer = new Employee(inputLine[0], double.Parse(inputLine[1]), inputLine[2], inputLine[3]);
                }

                if (!listOfDeps.ContainsKey(inputLine[3]))
                {
                    listOfDeps[inputLine[3]] = new List<Employee>();
                }

                listOfDeps[inputLine[3]].Add(currentEmployer);
            }

            var highest = listOfDeps.OrderByDescending(x => x.Value.Sum(e => e.Salary)).First();

            Console.WriteLine($"Highest Average Salary: {highest.Key}");
            foreach (var item in highest.Value.OrderByDescending(x=>x.Salary))
            {
                Console.WriteLine($"{item.Name} {item.Salary:F2} {item.Email} {item.Age}");
            }
        }
    }
}