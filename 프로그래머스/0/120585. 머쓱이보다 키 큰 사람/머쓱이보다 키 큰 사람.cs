using System;

public class Solution {
    public int solution(int[] array, int height) {
        int 큰놈수 =0;
        
        for (int i = 0; i< array.Length; i++)
        {
            if(array[i]>height)
            {
                큰놈수 ++;
            }
            
        }
        
        
        int answer = 큰놈수;
        return answer;
    }
}