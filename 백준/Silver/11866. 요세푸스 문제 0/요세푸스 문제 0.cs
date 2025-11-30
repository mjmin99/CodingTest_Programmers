using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        Queue<int> q = new Queue<int>();
        for (int i = 1; i <= N; i++)
            q.Enqueue(i);

        List<int> result = new List<int>();

        int count = 0;

        while (q.Count > 0)
        {
            count++;

            int x = q.Dequeue();

            if (count == K)
            {
                result.Add(x);
                count = 0;
            }
            else
            {
                q.Enqueue(x);
            }
        }

        StringBuilder sb = new StringBuilder();
        sb.Append("<");

        for (int i = 0; i < result.Count; i++)
        {
            sb.Append(result[i]);
            if (i != result.Count - 1)
                sb.Append(", ");
        }

        sb.Append(">");

        Console.WriteLine(sb.ToString());
    }
}
