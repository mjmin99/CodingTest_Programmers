using System;

public class Solution {
    public string solution(string my_string) {

        string lowerStr = my_string.ToLower();
        
        char[] charArray = lowerStr.ToCharArray();
        
        Array.Sort(charArray);
        
        
        return new string(charArray);
    }
}