using System;

class akswns
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());
        
        for(int t = 0; t < T; t++)
        {
            string s = Console.ReadLine();
            int count = 0;
            bool isVPS = true;
            
            foreach (char c in s)
            {
                if(c == '(') count ++;
                else count --;
                
                if(count < 0)
                {
                    isVPS = false;
                    break;
                }
            }
            
            if(count != 0)isVPS = false;
            
            Console.WriteLine(isVPS ? "YES" : "NO");
        }
        
    }
}