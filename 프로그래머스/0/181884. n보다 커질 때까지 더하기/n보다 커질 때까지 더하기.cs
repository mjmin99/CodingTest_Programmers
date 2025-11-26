using System;

public class Solution {
    public int solution(int[] numbers, int n) {
        int answer = 0;
        int sum = 0;
        
        for(int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            
            if(sum > n)
                return sum;
        }
        return answer;
    }
}