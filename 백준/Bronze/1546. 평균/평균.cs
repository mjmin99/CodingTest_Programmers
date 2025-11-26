using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();

        double[] scores = new double[N];
        for (int i = 0; i < N; i++)
            scores[i] = double.Parse(input[i]);

        double max = 0;

        for (int i = 0; i < N; i++)
        {
            if (scores[i] > max)
                max = scores[i];
        }

        double sum = 0;
        for (int i = 0; i < N; i++)
        {
            sum += (scores[i] / max) * 100.0;
        }

        double avg = sum / N;
        Console.WriteLine(avg);
    }
}