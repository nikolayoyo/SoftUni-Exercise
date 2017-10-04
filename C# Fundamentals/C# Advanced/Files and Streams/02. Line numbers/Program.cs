using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Line_numbers
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
                using (StreamWriter writer = File.CreateText("otherfile.txt"))
                {
                    var counter = 1;
                    var currentLine = reader.ReadLine();
                    while (currentLine != null)
                    {
                        writer.WriteLine($"{counter}. {currentLine}");
                        counter++;
                        currentLine = reader.ReadLine();
                    }
                }
            }
        }
    }
}
