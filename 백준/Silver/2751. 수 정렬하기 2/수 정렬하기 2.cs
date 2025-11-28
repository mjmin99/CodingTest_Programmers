using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int N = int.Parse(sr.ReadLine());

        // -1_000_000 ~ 1_000_000 → 인덱스 0 ~ 2_000_000 으로 매핑
        bool[] exist = new bool[2000001];

        for (int i = 0; i < N; i++)
        {
            int x = int.Parse(sr.ReadLine());
            exist[x + 1000000] = true;
        }

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < exist.Length; i++)
        {
            if (exist[i])
            {
                sb.Append(i - 1000000).Append('\n');
            }
        }

        sw.Write(sb.ToString());
        sw.Flush();
    }
}