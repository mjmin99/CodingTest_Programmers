using System;

public class Solution {
    public int solution(int num, int k) {
        int answer = 0;
        string str = num.ToString();     // num을 문자열로 변환
        char target = k.ToString()[0];   // k도 문자로 변환

        for (int i = 0; i < str.Length; i++) 
        {
            if (str[i] == target) 
            {
                return i + 1;             // 자리 수는 1부터 시작하므로 +1
            }
        }

        return -1; // 없을 경우
    }
}