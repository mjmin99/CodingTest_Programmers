using System;

public class Example
{
    public static void Main()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        String s1 = input[0];
        String s2 = input[1];

        Console.WriteLine(s1 + s2);
        // 위는 원래의 내 답인데 문자열의 덧셈을 하는 것 보다 아래처럼 문자열 보간으로 출력하는 것이 성능상의 이점이 있어서 그렇게 하는게 좋을 듯
        // Console.WriteLine($"{s1}{s2}"); 
    }
}