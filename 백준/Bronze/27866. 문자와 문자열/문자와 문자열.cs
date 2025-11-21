using System;

class akasa
{
    static void Main()
    {
        string str = Console.ReadLine();
        int a = int.Parse(Console.ReadLine());
        
        char c = str[a-1];
        Console.WriteLine(c);
    }
}