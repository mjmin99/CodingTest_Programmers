using System;
using System.Collections.Generic;

public class Program {
    public static void Main() {
        int N = int.Parse(Console.ReadLine());
        Queue<int> q = new Queue<int>();

        // 1 ~ N 카드 담기
        for (int i = 1; i <= N; i++) {
            q.Enqueue(i);
        }

        // 한 장 남을 때까지 반복
        while (q.Count > 1) {
            q.Dequeue();               // 1) 맨 위 카드 버리기
            q.Enqueue(q.Dequeue());    // 2) 다음 맨 위 카드를 맨 아래로 옮기기
        }

        Console.WriteLine(q.Dequeue()); // 마지막 카드 출력
    }
}