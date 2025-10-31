using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        foreach (char c in my_string)
        {
            if(char.IsUpper(c))
            {
                answer += char.ToLower(c); // 문자를 소문자로 만드는 함수
            }
            else
            {
                answer += char.ToUpper(c); // 문자를 대문자로 만드는 함수
            }
        }
        
        return answer;
    }
}