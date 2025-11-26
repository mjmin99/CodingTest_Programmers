using System;

public class Solution {
    public string[] solution(string[] names) {
        int n = 5;
        int count = (names.Length + n - 1) / n; 
        string[] answer = new string[count];
        
        for(int i = 0;i < count; i++)
        {
            answer[i] += names[i*n];
        }
        return answer;
    }
}