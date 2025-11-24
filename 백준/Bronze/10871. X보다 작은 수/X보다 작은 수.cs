using System;

class wlsdud
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int X = int.Parse(input[1]);
        
        string[] num = Console.ReadLine().Split();
        
        for (int i = 0; i < N; i++)
        {
            int value = int.Parse(num[i]);
            if (value < X)
                Console.Write($"{value} ");
        }
    }
}