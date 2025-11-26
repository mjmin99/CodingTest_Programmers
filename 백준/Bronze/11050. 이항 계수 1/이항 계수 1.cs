using System;

class Program
{
    static int Fact(int n)
    {
        int result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        int answer = Fact(N) / (Fact(K) * Fact(N - K));
        Console.WriteLine(answer);
    }
}