using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        
        int count = 1;
        
        while(N > 1)
        {
            N -= 6 * count;
            count++;
        }
        
        Console.WriteLine(count);
    }
}