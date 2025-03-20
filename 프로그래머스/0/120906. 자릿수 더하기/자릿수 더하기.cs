using System;

public class Solution {
    public int solution(int n) {
            int answer = 0;
            string s = n.ToString();
            char[] c = s.ToCharArray();
            int[] number = new int [c.Length];

            for (int i = 0; i < c.Length; i++)
            {
                number[i] = (int)c[i] - '0';
            }

            for(int j = 0; j < c.Length; j++)
            {
                answer += number[j];
            }
        return answer;
    }
}