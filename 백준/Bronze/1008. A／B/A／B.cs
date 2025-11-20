// 두 정수 A와 B를 입력받은 다음, A/B를 출력하는 프로그램을 작성하시오.
using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        
        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        
        Console.WriteLine(a/b);
    }
}