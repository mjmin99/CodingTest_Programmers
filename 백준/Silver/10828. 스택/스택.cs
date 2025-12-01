using System;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        int[] stack = new int[n];   // 최대 n번 push 가능
        int top = -1;               // 비어있을 땐 -1
        
        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < n; i++)
        {
            string cmd = Console.ReadLine();
            
            if (cmd.StartsWith("push"))
            {
                string[] parts = cmd.Split(' ');
                int x = int.Parse(parts[1]);
                stack[++top] = x;
            }
            else if (cmd == "pop")
            {
                if (top == -1)
                {
                    sb.AppendLine("-1");
                }
                else
                {
                    sb.AppendLine(stack[top--].ToString());
                }
            }
            else if (cmd == "size")
            {
                sb.AppendLine((top + 1).ToString());
            }
            else if (cmd == "empty")
            {
                sb.AppendLine(top == -1 ? "1" : "0");
            }
            else if (cmd == "top")
            {
                if (top == -1)
                {
                    sb.AppendLine("-1");
                }
                else
                {
                    sb.AppendLine(stack[top].ToString());
                }
            }
        }
        
        Console.Write(sb.ToString());
    }
}
