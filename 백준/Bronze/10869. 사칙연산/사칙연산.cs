using System;

class asdasd
{
    static void Main()
    {
        string[] d = Console.ReadLine().Split();
        
        int a = Int32.Parse(d[0]);
        int b = Int32.Parse(d[1]);
        
        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
        Console.WriteLine(a % b);
    }
}