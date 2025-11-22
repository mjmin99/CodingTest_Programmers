using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arr = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(arr.Length);
    }
}