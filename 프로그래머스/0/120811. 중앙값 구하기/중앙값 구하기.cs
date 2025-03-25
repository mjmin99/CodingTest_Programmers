using System;
//스왑함수사용의 예시가 되겠군
public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        for(int i = 0; i < array.Length-1; i++)
        {
            for(int j = i + 1; j < array.Length; j++)
            {
                if(array[i] > array[j])
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;                    
                }
                
            }
        }
        answer = array[array.Length/2];
        
        return answer;
    }
}