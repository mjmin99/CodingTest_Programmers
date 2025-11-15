using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        String result = "";
        
        foreach (char c in s) // s의 문자열을 변수 c에 담아 반복한다는 뜻
        {
            if(char.IsLower(c))
            {
                result += char.ToUpper(c);
            }
            else
            {
                result += char.ToLower(c);
            }
        }
        
        Console.WriteLine(result);
    }
}