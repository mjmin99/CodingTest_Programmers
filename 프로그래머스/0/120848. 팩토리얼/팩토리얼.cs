using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int temp = 1; // 임시
        
        for(int i = 1; i <= 10; i++) // 1부터 10 까지
        {
            temp *= i; //팩토리얼 계산
            if(temp >= n) // 계산된 팩토리얼 값이 보다 크냐?n
            {
                answer = temp > n ? i -1 :i; // 삼항 연산자로 크면 이전 안크면 그대로 놓고 브레이크 결과산출
                break;
            }
            
        }
        return answer;
    }
}