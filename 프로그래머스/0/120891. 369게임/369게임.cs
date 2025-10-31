using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;
        int count = 0;
        char[] digits = order.ToString().ToCharArray();
        
        for(int i = 0; i <digits.Length; i++)
        {
            if(digits[i] == '3' || digits[i] == '6' || digits[i] == '9')
            {
                count++;
            }
        }
        answer = count;
        
        
        return answer;
    }
}