using System;

public class Solution {
    public int solution(int n, int t) {
        int answer = 0;
        int result = 1;
            for (int i = 0; i < t; i++)
            {
                result *= 2;
            }
        answer = n * result;
        return answer;
    }
}