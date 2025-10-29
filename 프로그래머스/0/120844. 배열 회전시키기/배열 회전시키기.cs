using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = new int[numbers.Length];
        
        //오른쪽과 왼쪽에 따라 인덱스를 다르게 지정하기
        int num = 0; 
        
        if(direction == "right")
        {
            num = 1;
        }
        else
        {
            num = numbers.Length -1;
        }
        
        
        for(int i = 0; i < numbers.Length; i++)
        {
            if(num == numbers.Length)
            {
                num = 0;
            }
            answer[num] = numbers[i];
            num++;
        }
        return answer;
    }
}