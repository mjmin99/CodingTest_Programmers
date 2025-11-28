using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class Person
{
    public int Age;
    public string Name;
    public int Order;   // 입력된 순서

    public Person(int age, string name, int order)
    {
        Age = age;
        Name = name;
        Order = order;
    }
}

class Program
{
    static void Main()
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int N = int.Parse(sr.ReadLine());
        List<Person> list = new List<Person>(N);

        for (int i = 0; i < N; i++)
        {
            string[] input = sr.ReadLine().Split();
            int age = int.Parse(input[0]);
            string name = input[1];

            // 입력 순서를 저장
            list.Add(new Person(age, name, i));
        }

        // 1. 나이 오름차순
        // 2. 나이가 같으면 입력 순서 오름차순
        list.Sort((a, b) =>
        {
            int r = a.Age.CompareTo(b.Age);
            if (r == 0)
                return a.Order.CompareTo(b.Order);
            return r;
        });

        StringBuilder sb = new StringBuilder();

        foreach (var p in list)
            sb.Append(p.Age).Append(' ').Append(p.Name).Append('\n');

        sw.Write(sb.ToString());
        sw.Flush();
    }
}