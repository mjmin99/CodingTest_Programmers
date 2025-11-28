using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        
        foreach(char c in myString)
        {
            if(c == 'a')
            {answer += 'A';}
            else if(c == 'A')
            {answer += 'A';}
            else
            {answer += char.ToLower(c);}
        }
        
        return answer;
    }
}