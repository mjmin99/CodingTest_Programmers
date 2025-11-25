using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[,] intervals) {
        List<int> list = new List<int>(arr);
        
        int a1 = intervals[0, 0];
        int b1 = intervals[0, 1];
        int a2 = intervals[1, 0];
        int b2 = intervals[1, 1];
        
        // List의 GetRange(start, count)를 통해 부분 리스트 추출
        List<int> part1 = list.GetRange(a1, b1 - a1 + 1);
        List<int> part2 = list.GetRange(a2, b2 - a2 + 1);
        
        List<int> answer = new List<int>();
        answer.AddRange(part1);
        answer.AddRange(part2);
        
        return answer.ToArray();
    }
}


// 변수명.AddRange(part1);