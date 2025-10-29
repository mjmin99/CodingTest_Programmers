using System;

public class Solution 
{
    public int solution(int n) 
    {
        int answer = 0;
        
        int count = 0; //인덱스 하나 만들고
        
        for(int i = 1; i <= n; i++) // n 이하의 자연수 안을 모두 탐색
        {
            for(int j = 1; j <= i; j++) // n 이하의 자연수 i가 1부터 j 까지의 수로 나눠떨어지는지 확인
            {
                if(i % j == 0) // 나누어 떨어지는 경우에
                {
                    count++; // 인덱스 하나 올리고
                }
            }
            if(count >= 3) // 그것이 총 세개가 넘으면 합성수라고 판정
            {
                answer++; // 정답의 갯수를 하나 올린다
            }
            count = 0; // 그리고 카운트 초기화
        }
        
        return answer;
    }
}