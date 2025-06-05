using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
                double sqrt = Math.Sqrt(n);            // n의 제곱근
        if (sqrt == (int)sqrt) {               // 제곱근이 정수인지 확인
            return 1;
        } else {
            return 2;
        }
        return answer;
    }
}