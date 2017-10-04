using System;

public class InputReader: IInputReader
{
    public string ReadLine()
    {
        return Console.ReadLine().Trim();
    }
}