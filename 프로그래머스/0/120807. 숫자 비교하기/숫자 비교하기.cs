using System;

public class Solution {
    public int solution(int num1, int num2) {
        int a = (num1 - num2);
        int answer = 0;
        if (a == 0)
        {
            answer = 1;
        }
        else
        {
            answer = -1;
        }
        return answer;
    }
}