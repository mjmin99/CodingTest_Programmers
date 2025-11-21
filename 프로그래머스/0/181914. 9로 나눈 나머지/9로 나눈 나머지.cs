using System;

public class Solution {
    public int solution(string number) {
        int sum = 0;

        foreach(char c in number)
        {
            sum += (c - '0'); // 문자 → 정수 변환
        }

        return sum % 9;
    }
}