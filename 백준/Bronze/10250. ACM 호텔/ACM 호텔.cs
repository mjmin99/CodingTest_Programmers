using System;

class akswns
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < T; i++)
        {
            string[] input = Console.ReadLine().Split();
            int H = int.Parse(input[0]);
            int W = int.Parse(input[1]); 
            int N = int.Parse(input[2]); 
            
            int floor = (N - 1) % H + 1; 
            int room  = (N - 1) / H + 1; 
            
            Console.WriteLine($"{floor}{room:D2}");
        }
    }
}
