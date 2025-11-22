using System;

public class Solution {
    public string solution(string[] my_strings, int[,] parts) {
        string answer = "";
        
        for(int i = 0; i < my_strings.Length; i++)
        {
            string str = my_strings[i];
            
            int s = parts[i,0];
            int e = parts[i,1];
            
            
            answer += str.Substring(s, e - s +1);
        }
        
        
        return answer;
    }
}