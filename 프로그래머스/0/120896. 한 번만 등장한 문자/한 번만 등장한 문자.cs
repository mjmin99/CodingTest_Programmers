using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] chars = s.ToCharArray();
            
        Array.Sort(chars); // 정렬
        
        for (int i = 0; i < chars.Length; i++)
        {
           bool isUnique = (i == 0 || chars[i] != chars[i - 1]) && (i == chars.Length -1 || chars[i] != chars[i +1]);
            
            if(isUnique)
                answer += chars[i];
        }
        
        return answer;
    }
}