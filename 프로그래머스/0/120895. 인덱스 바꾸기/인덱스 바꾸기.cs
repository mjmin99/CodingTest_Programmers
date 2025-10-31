using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        string answer = "";
        char[] chars = my_string.ToCharArray(); // 문자열을 문자 배열로 변환
        
        char temp = chars[num1];
        chars[num1] = chars[num2];
        chars[num2] = temp;
        
       
        answer = new string(chars);
        return answer;
    }
}