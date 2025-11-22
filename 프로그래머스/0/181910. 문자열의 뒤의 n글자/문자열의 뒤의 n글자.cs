using System;

public class Solution {
    public string solution(string my_string, int n) {
        int index = 0;
        foreach(char s in my_string)
        {
            index++;
        }
        string answer = my_string.Substring(index-n);
        
        return answer;
    }
}