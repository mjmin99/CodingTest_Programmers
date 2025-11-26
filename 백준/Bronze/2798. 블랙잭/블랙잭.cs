using System;

class akswns
{
    static void Main()
    {
        string[] nm = Console.ReadLine().Split();
        int N = int.Parse(nm[0]);
        int M = int.Parse(nm[1]);
        
        string[] input = Console.ReadLine().Split();
        int[] cards = new int[N];
        for (int i = 0; i < N; i++)
            cards[i] = int.Parse(input[i]);
        
        int best = 0;
        
        for (int i = 0; i < N - 2; i++)
        {
            for (int j = i + 1; j < N - 1; j++)
            {
                for (int k = j + 1; k < N; k++)
                {
                    int sum = cards[i] + cards[j] + cards[k];

                    if (sum == M)
                    {
                        Console.WriteLine(M);
                        return;
                    }

                    if (sum < M && sum > best)
                        best = sum;
                }
            }
        }

        Console.WriteLine(best);
    }
}