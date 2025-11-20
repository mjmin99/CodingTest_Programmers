// N을 입력받은 뒤, 구구단 N단을 출력하는 프로그램을 작성하시오. 출력 형식에 맞춰서 출력하면 된다.
using System;

class akswns
{
    static void Main()
    {
        int num = Int32.Parse(Console.ReadLine());
        
        for(int i = 1; i < 10; i++)
        {
            Console.WriteLine($"{num} * {i} = {num*i}");
        }
    }
}