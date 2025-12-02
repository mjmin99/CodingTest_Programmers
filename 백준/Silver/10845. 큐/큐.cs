using System;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // 명령 몇개 들어오는지 입력
        int[] queue = new int[n];   // 최대 n번 push 가능
        int front = 0;
        int rear = 0;
     
        StringBuilder sb = new StringBuilder(); // 출력에서 시간 효율을 위해 스트링빌더
        
        for (int i = 0; i < n; i++) // n 개의 명령을 처리하기 위해
        {
            string cmd = Console.ReadLine(); // 입력을 저장
            
            if(cmd.StartsWith("push"))
            {
                string[] parts = cmd.Split(' ');
                int x = int.Parse(parts[1]);
                queue[rear++] = x;
            }
            else if(cmd == "pop")
            {
                if (front == rear)
                    sb.AppendLine("-1");
                else
                    sb.AppendLine(queue[front++].ToString());
            }
            else if(cmd == "size")
            {
                 sb.AppendLine((rear - front).ToString());
            }
            else if(cmd == "empty")
            {
                 sb.AppendLine((front == rear ? 1 : 0).ToString());
            }
            else if(cmd == "front")
            {
                if (front == rear)
                    sb.AppendLine("-1");
                else
                    sb.AppendLine(queue[front].ToString());
            }
            else if(cmd == "back")
            {
                if (front == rear)
                    sb.AppendLine("-1");
                else
                    sb.AppendLine(queue[rear - 1].ToString());
            }
        }
        Console.Write(sb.ToString());
    }
}