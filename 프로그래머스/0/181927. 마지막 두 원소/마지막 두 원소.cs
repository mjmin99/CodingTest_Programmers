using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length + 1];
        
        // 원본 복사
        for(int i = 0; i < num_list.Length; i++)
        {
            answer[i] = num_list[i];        
        }
        
        int last = num_list[num_list.Length - 1]; // -1 해준게 마지막값 0부터 시작이라
        int beforeLast = num_list[num_list.Length - 2];
        
        if(last > beforeLast)
        {
            answer[num_list.Length] = last - beforeLast;
        }
        else
        {
            answer[num_list.Length] = last * 2;
        }
        
    
        
        return answer;
    }
}