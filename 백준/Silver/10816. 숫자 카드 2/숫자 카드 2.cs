using System;
using System.Collections.Generic;

public class Program
{
     public static void Main() 
     {
         int N = int.Parse(Console.ReadLine());
         string[] cardsInput = Console.ReadLine().Split();
         Dictionary<int, int> countMap = new Dictionary<int, int>();
         
         // 상근이가 가진 카드 개수 기록
         for (int i = 0; i < N; i++)
         {
             int num = int.Parse(cardsInput[i]);
             if (countMap.ContainsKey(num))
                 countMap[num]++;
             else
                 countMap[num] = 1;
         }
         
         int M = int.Parse(Console.ReadLine());
         string[] queryInput = Console.ReadLine().Split();
         
         // 결과 저장
         System.Text.StringBuilder sb = new System.Text.StringBuilder();
         for (int i = 0; i < M; i++)
         {
             int num = int.Parse(queryInput[i]);
 
             if (countMap.ContainsKey(num))
                 sb.Append(countMap[num] + " ");
             else
                 sb.Append("0 ");
         }
 
         Console.WriteLine(sb.ToString());

     }
}
   