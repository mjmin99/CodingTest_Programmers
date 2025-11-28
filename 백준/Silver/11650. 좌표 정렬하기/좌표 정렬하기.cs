using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Program
{
    static void Main()
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());
        
        int N = int.Parse(sr.ReadLine());

        List<Point> list = new List<Point>(N);
        
        for (int i = 0; i < N; i++)
        {
            string[] input = sr.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            list.Add(new Point(x, y));
        }
        
        // 정렬: x 오름차순 → x 같으면 y 오름차순
        list.Sort((a, b) =>
        {
            int r = a.X.CompareTo(b.X);
            if (r == 0)
                return a.Y.CompareTo(b.Y);
            return r;
        });

        StringBuilder sb = new StringBuilder();

        foreach (var p in list)
        {
            sb.Append(p.X).Append(' ').Append(p.Y).Append('\n');
        }

        sw.Write(sb.ToString());
        sw.Flush();
    }
}







