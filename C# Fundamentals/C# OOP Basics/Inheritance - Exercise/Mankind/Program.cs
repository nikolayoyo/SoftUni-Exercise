using System;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            var studentParam = Console.ReadLine().Split();
            var workerParams = Console.ReadLine().Split();

            var myStud = new Student(studentParam[0], studentParam[1], studentParam[2]);

            var myWorker = new Worker(workerParams[0], workerParams[1], double.Parse(workerParams[2]), int.Parse(workerParams[3]));

            Console.WriteLine(myStud);
            Console.WriteLine();
            Console.WriteLine(myWorker);
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine(ex.Message);
        }
        
    }
}

