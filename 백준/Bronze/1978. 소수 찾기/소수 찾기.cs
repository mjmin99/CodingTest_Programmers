using System;

class akswns
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        int[] arr = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            arr[i] = int.Parse(input[i]);
        }
        
        int primeCount = 0;
        
        for(int idx = 0; idx < arr.Length; idx++)
        {
            int n = arr[idx];

            if (n <= 1) continue;
            if (n == 2)
            {
                primeCount++;
                continue;
            }
            if (n % 2 == 0) continue;  // 짝수는 소수 아님
            
            bool isPrime = true;
            long limit = (long)Math.Sqrt(n);
            
            for (long d = 3; d <= limit; d += 2)
            {
                if (n % d == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                primeCount++;
        }

        Console.WriteLine(primeCount);
    }
}