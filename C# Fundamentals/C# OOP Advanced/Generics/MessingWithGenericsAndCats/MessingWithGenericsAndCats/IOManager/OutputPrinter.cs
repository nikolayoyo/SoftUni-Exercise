
namespace MessingWithGenericsAndCats.IOManager
{
    using System;

    public static class OutputPrinter
    {
        public static void PrintLine(string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintEmptyLine()
        {
             Console.WriteLine();
        }

        public static void Print(string message)
        {
             Console.Write(message);
        }
    }
}
