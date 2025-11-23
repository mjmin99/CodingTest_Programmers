using System;
using System.Text;

class Program {
    static void Main() {
        int N = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();

        for (int i = 1; i <= N; i++) {
            sb.Append(i);
            sb.Append('\n');
        }

        Console.Write(sb.ToString());
    }
}