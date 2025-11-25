using System;

public class Program
{
    public static void Main()
    {
        long N = long.Parse(Console.ReadLine());

        string[] t = Console.ReadLine().Split();
        long S = long.Parse(t[0]);
        long M = long.Parse(t[1]);
        long L = long.Parse(t[2]);
        long XL = long.Parse(t[3]);
        long XXL = long.Parse(t[4]);
        long XXXL = long.Parse(t[5]);

        string[] tp = Console.ReadLine().Split();
        long T = long.Parse(tp[0]);
        long P = long.Parse(tp[1]);

        long tshirtBundles = 
            (S + T - 1) / T +
            (M + T - 1) / T +
            (L + T - 1) / T +
            (XL + T - 1) / T +
            (XXL + T - 1) / T +
            (XXXL + T - 1) / T;

        long penBundles = N / P;
        long penSingles = N % P;

        Console.WriteLine(tshirtBundles);
        Console.WriteLine($"{penBundles} {penSingles}");
    }
}