using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        if(n % 2 == 0) // even
        {
            for(int i = 0 ; i <= n; i++)
            {
                if(i % 2 == 0) // 짝수일때만
                {
                    answer += i*i;
                }
            }
        }
        else // odd
        {
            for(int i = 0 ; i <= n; i++)
            {
                if(i % 2 == 1) // 홀수일때만
                {
                    answer += i ;
                }
            }
        }
        return answer;
    }
}

// 반복문의 범위를 잘못 넣어줬기 때문에 오류가 났음 < 로 하면 이하의 홀수든 짝수든 n 자기자신 포함이 안되기 때문에 <= 해줘야 하는 문제였음