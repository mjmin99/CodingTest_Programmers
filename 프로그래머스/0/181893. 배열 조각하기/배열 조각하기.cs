using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[] query) 
    {
        foreach (int i in Enumerable.Range(0, query.Length))
        {
            if (i % 2 == 0)    // 짝수 인덱스 → 뒤 자르기
            {
                arr = arr.Take(query[i] + 1).ToArray();
            }
            else              // 홀수 인덱스 → 앞 자르기
            {
                arr = arr.Skip(query[i]).ToArray();
            }
        }

        return arr;
    }
}

// 이해못했음