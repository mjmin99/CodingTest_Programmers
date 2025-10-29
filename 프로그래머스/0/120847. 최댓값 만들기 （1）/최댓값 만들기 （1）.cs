using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int maxnum = 0; // 최댓값을 저장할 변수 하나
        
        for(int i = 0; i< numbers.Length; i++) // 넘버스의 모든 배열 수들을
        {
            for(int j = 0; j< numbers.Length; j++) //넘버스의 모든 배열 수와 곱해본다
            {
                if(i == j) // 단 같은 숫자 끼린 비교하지 않고 넘어간다
                {
                    
                }
                else // 다른 숫자라면 비교 시작
                {
                    if(maxnum < numbers[i]*numbers[j]) // 만약 넘버스의 모든 수 들 중 어떠한 두 수의 곱이 맥스 넘버 보다 크다면
                    {
                        maxnum = numbers[i]*numbers[j]; // 맥스 넘버를 교체한다.
                    }
                }
            }
        }
        answer = maxnum; // 정답에 입력한다.
        return answer;
    }
}