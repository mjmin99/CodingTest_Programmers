using System;

class Program
{
    static void Main()
    {
        int max = 0;
        int index = 0;

        for (int i = 1; i <= 9; i++)
        {
            int n = int.Parse(Console.ReadLine());
            if (n > max)
            {
                max = n;
                index = i;
            }
        }

        Console.WriteLine(max);
        Console.WriteLine(index);
    }
}