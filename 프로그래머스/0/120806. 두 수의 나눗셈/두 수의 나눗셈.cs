using System;

public class Solution {
    public int solution(int num1, int num2) {
        float money = (float)num1 / num2 * 1000;
        int answer = (int)money;
        return answer;
    }
}