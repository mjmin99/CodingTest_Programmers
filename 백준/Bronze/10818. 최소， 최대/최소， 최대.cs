using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();

        int min = int.MaxValue;
        int max = int.MinValue;

        for (int i = 0; i < N; i++)
        {
            int num = int.Parse(input[i]);
            if (num < min) min = num;
            if (num > max) max = num;
        }

        Console.WriteLine($"{min} {max}");
    }
}