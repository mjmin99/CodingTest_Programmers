using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        
        int len = num_list.Length;
        
        int[] answer = new int[len];
        
        int idx = 0;
        
        // n 부터 끝
        for(int i = n; i < len; i++)
        {
            answer[idx++] = num_list[i];
        }
        
        for(int i = 0; i < n; i++)
        {
            answer[idx++] = num_list[i];
        }
    
        return answer;
    }
}