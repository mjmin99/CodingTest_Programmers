using System;

class akswns
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string input = Console.ReadLine();
            int score = 0;
            int idx = 1;

            foreach (char c in input)
            {
                if (c == 'O')
                {
                    score += idx;
                    idx++;
                }
                else  // 'X'
                {
                    idx = 1;
                }
            }

            Console.WriteLine(score);
        }
    }
}
