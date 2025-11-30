using System;

public class Solution {
    public string[] solution(string myString) {
        // string[] answer = myString.Split('x'); 아래처럼 빈 문자열 제거 옵션을 사용하면 편리함
        
        string[] answer = myString.Split('x', StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(answer);
        return answer;
    }
}