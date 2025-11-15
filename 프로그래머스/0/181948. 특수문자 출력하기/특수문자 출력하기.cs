using System;

public class Example
{
    public static void Main()
    {
        Console.WriteLine("!@#$%^&*(\\'\"<>?:;");
      //Console.WriteLine(!@#$%^&*(\'"<>?:;); 그냥 하면 안되고 백슬래시를 통해 이스케이프시켜야한다.
    }
}

// 문자열 출력시 이스케이프를 할 줄 아냐를 묻는 문제 \ 와 ' 와 " 의 앞에는 \(백슬래시) 를 넣어서 출력 가능하게해야함