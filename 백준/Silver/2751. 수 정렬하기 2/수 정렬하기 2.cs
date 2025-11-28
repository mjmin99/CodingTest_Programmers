using System;
using System.Text;

class akswns
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        
        int[] input = new int[N];
        
        for (int i = 0; i < N; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(input);

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < N; i++)
        {
            sb.AppendLine(input[i].ToString());
        }

        Console.Write(sb.ToString());
    }
}