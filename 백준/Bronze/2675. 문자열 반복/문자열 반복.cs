using System;

class Program
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            string[] input = Console.ReadLine().Split();
            int R = int.Parse(input[0]);
            string S = input[1];

            string result = "";

            foreach (char c in S)
            {
                for (int j = 0; j < R; j++)
                {
                    result += c;
                }
            }

            Console.WriteLine(result);
        }
    }
}