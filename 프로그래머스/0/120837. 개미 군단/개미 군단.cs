using System;

public class Solution {
    public int solution(int hp) {
        int answer = 0;
        answer += hp / 5;
        int a = hp % 5;
        answer += a / 3;
        int b = a % 3;
        answer += b;
        return answer;
    }
}