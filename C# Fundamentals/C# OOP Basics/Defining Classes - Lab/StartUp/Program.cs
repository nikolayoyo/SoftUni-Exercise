using System;
using System.Collections.Generic;

public class Program
{
    private static Dictionary<int, BankAccount> myAccounts = new Dictionary<int, BankAccount>();
    static void Main()
    {
        string input;
        while ((input= Console.ReadLine()) != "End")
        {
            var cmdArgs = input.Split();

            var cmdType = cmdArgs[0];

            switch (cmdType)
            {
                case "Create":
                    Create(cmdArgs);
                    break;
                case "Deposit":
                    Deposint(cmdArgs);
                    break;
                case "Withdraw":
                    Withdraw(cmdArgs);
                    break;
                case "Print":
                    Print(cmdArgs);
                    break;
                default:
                    break;
            }
        }
        
    }

    private static void Print(string[] cmdArgs)
    {
        var id = int.Parse(cmdArgs[1]);
        if (!myAccounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        Console.WriteLine(myAccounts[id].ToString());
    }

    private static void Withdraw(string[] cmdArgs)
    {
        var id = int.Parse(cmdArgs[1]);
        if (!myAccounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        var value = int.Parse(cmdArgs[2]);
        if (myAccounts[id].Balance<value)
        {
            Console.WriteLine("Insufficient balance");
            return;
        }

        myAccounts[id].Withdraw(value);
    }

    private static void Deposint(string[] cmdArgs)
    {
        var id = int.Parse(cmdArgs[1]);
        if (!myAccounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        myAccounts[id].Deposit(int.Parse(cmdArgs[2]));
    }

    private static void Create(string[] cmdArgs)
    {
        var id = int.Parse(cmdArgs[1]);
        if (myAccounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
            return;
        }

        var acc = new BankAccount();
        acc.ID = id;
        myAccounts[id] = acc;
    }
}

