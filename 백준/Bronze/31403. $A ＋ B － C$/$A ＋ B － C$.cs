using System;

class Program
{
    static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        string c = Console.ReadLine();

        int ai = int.Parse(a);
        int bi = int.Parse(b);
        int ci = int.Parse(c);
        Console.WriteLine(ai + bi - ci);

        string ab = a + b;
        int abi = int.Parse(ab);
        Console.WriteLine(abi - ci);
    }
}