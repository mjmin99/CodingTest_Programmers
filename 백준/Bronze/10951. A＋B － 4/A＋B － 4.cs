using System;

class akswns
{
    static void Main()
    {
        string line;
        while((line = Console.ReadLine()) != null)
        {
            string[] input = line.Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            
            Console.WriteLine(a+b);
        }
    }
}
