using System;

class akswns
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        
       
            int zero = 0;
 
            int one = 0;
 
            int two = 0;

            int three = 0;

            int four = 0;

            int five = 0;

            int six = 0;

            int seven = 0;

            int eight = 0;

            int nine = 0;
        
        int num = A*B*C;
        string ABC = num.ToString();
        foreach(char c in ABC)
        {
            if(c == '0')
            zero ++;
            if(c == '1')
            one ++;
            if(c == '2')
            two ++;
            if(c == '3')
            three++;
            if(c == '4')
            four++;
            if(c == '5')
            five++;
            if(c == '6')
            six++;
            if(c == '7')
            seven++;
            if(c == '8')
            eight++;
            if(c == '9')
            nine++;
        }
            Console.WriteLine(zero);
            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine(three);
            Console.WriteLine(four);
            Console.WriteLine(five);
            Console.WriteLine(six);
            Console.WriteLine(seven);
            Console.WriteLine(eight);
            Console.WriteLine(nine);
    }
}