using System;

public class Solution {
    public int[] solution(int[] arr) {
        int n = 0;
        
        for(int i = 0; i < arr.Length; i++)
        {
            n += arr[i];
        }
        
        int[] answer = new int[n];
        
        int index = 0;
        
        for(int i = 0; i < arr.Length; i++)
        {
            int x = arr[i];
            
            for(int j = 0; j < x; j++)
            {
                answer[index] = arr[i];
                index++;
            }
        }
        
        
        return answer;
    }
}