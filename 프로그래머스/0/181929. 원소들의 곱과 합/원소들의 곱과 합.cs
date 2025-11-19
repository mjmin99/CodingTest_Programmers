using System;

public class Solution {
    public int solution(int[] num_list) {
        
        int sum = 0;
        int mul = 1; // <- 모든 곱이라면 처음 초기화를 0을 집어넣으면 안되는 법이다... 
        
        for(int i = 0; i <num_list.Length; i++)
        {
            sum += num_list[i]; // 모든합
            mul *= num_list[i]; // 모든곱
        }
        
        sum *= sum;
        
        if(mul < sum)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}