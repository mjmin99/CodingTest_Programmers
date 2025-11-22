using System;

class akswns
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int sum = 0;
        for(int i = 0; i < input.Length; i++)
        {
            int num = int.Parse(input[i]);
            sum += num * num;
        }
        Console.WriteLine(sum%10);
    }
}