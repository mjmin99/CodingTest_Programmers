using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int oddSum = 0;
        int evenSum = 0;
        
        for(int i = 0; i < num_list.Length; i++)
        {
            if(i % 2 == 0) // 홀
            {
                oddSum += num_list[i];
            }
            else // 짝
            {
                evenSum += num_list[i];
            }
        }
        
        if(oddSum > evenSum)
        {
            return oddSum;
        }
        else if(oddSum < evenSum)
        {
            return evenSum;
        }
        else if(oddSum == evenSum)
        {
            return oddSum;
        }
        return answer; // 차피 이쪽으로 안 감
    }
}