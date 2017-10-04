using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter createIt = File.CreateText("sometext.txt"))
            {
                createIt.Write($@"-I was quick to judge him, but it wasn't his fault.{Environment.NewLine}- Is this some kind of joke ? !Is it ?{Environment.NewLine}-Quick, hide here…It is safer.");
            }

            using (StreamWriter wordsToFind = File.CreateText("wordstofind.txt"))
            {
                wordsToFind.WriteLine("quick");
                wordsToFind.WriteLine("is");
                wordsToFind.WriteLine("fault");
            }
            
                using (StreamReader wordsToFind = new StreamReader("wordstofind.txt"))
                {
                    var counter = new Dictionary<string, int>();
                    var searchWord = wordsToFind.ReadLine();
                    while (searchWord!=null)
                    {
                        counter[searchWord] = 0;
                        searchWord = wordsToFind.ReadLine();
                    }

                    var keys = new List<string>(counter.Keys);
                    foreach (var item in keys)
                    {
                        using (StreamReader textToRead = new StreamReader("sometext.txt"))
                        {
                            var currentLine = textToRead.ReadLine();
                            while (currentLine != null)
                            {
                                counter[item] += Regex.Matches(Regex.Escape(currentLine).ToLower(), item).Count;


                                currentLine = textToRead.ReadLine();
                            }
                        }
                    }

                    foreach (var item in counter.OrderByDescending(x=>x.Value))
                    {
                        Console.WriteLine($"{item.Key} -{item.Value}");
                    }
                }
            }
        } 
    }

