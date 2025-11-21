using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        
        int start = n - 1; // n번째 원소의 실제 인덱스
        int[] answer = new int[num_list.Length - start];

        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = num_list[start + i];
        }

        return answer;
    }
}