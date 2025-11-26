using System;

class akswns
{
    static void Main()
    {
        while(true)
        {
            string input = Console.ReadLine();
            
            if(input == "0")
                break;
            
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);


            if(input == reversed)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}