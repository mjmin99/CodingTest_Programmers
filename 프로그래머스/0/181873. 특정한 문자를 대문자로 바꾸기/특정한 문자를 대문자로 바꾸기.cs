using System;

public class Solution {
    public string solution(string my_string, string alp) {
        string answer = "";
        char target = alp[0]; // 바꿀 문자
        char targetLower = char.ToLower(target);
        char targetUpper = char.ToUpper(target);

        for(int i = 0; i < my_string.Length; i++)
        {
            if (char.ToLower(my_string[i]) == targetLower)
                answer += targetUpper;      // 대문자로 변환해서 추가
            else
                answer += my_string[i];     // 그대로 추가
        }
        
        return answer;
    }
}