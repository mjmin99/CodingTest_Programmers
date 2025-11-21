using System;

class akswns
{
    static void Main()
    {
        while(true)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            
            if(a+b ==0)
                break;
            
            Console.WriteLine(a+b);
        }
        
    }
}