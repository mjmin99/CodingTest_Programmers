using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int count = (num_list.Length + n - 1) / n;
        int[] answer = new int[count];
        
        for(int i = 0; i < count; i++)
        {
           answer[i] = num_list[i*n];
        }
        
        return answer;
    }
}