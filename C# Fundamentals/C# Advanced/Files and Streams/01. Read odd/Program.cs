using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Read_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter creator = File.CreateText("somefile.txt"))
            {
                for (int i = 0; i < 20; i++)
                {
                    creator.WriteLine((char)('a' + i));
                }
            }

            using (StreamReader reader = new StreamReader("somefile.txt"))
            {
                var counter = 1;
                var line = reader.ReadLine();
                while (line!=null)
                {
                    if (counter%2==1)
                    {
                        Console.WriteLine(line);
                    }
                    line = reader.ReadLine();
                    counter++;
                }
            }
        }
    }
}
