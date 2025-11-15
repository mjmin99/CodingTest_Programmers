using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        
    }
}

// 1. 이 문제를 풀기 위해 필요했던 지식
// Console.WriteLine("아무 문자열~~~{0}", 변수) 를 하면 변수가 {0} 자리에 알아서 들어간다는 점

// 문자열 보간 이라는 것도 있음
// https://soso-study.tistory.com/96