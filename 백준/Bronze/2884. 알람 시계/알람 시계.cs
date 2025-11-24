using System;

class akswns
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int H = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        
        M -= 45;
        if(M < 0)
        {
            M += 60;
            H--;
            if(H < 0)
                H = 23;
        }
        
        Console.WriteLine($"{H} {M}");
    }
}