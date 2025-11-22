using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            string spaces = new string(' ', N - i);
            string stars = new string('*', i);
            Console.WriteLine(spaces + stars);
        }
    }
}