using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        foreach(char a in s)
        {
            Console.WriteLine(a);
        }
    }
}