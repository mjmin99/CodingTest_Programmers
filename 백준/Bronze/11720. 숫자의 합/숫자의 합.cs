using System;

class asasddsa
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();
        
        int answer = 0;
        foreach (char a in str)
        {
            answer += a - '0';   // 문자 → 숫자 변환
        }

        Console.WriteLine(answer);
    }
}