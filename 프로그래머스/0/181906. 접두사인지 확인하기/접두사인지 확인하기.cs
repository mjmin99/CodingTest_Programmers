using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        List<string> str = new List<string>();
        
        for(int i = 0; i < my_string.Length; i++)
        {
            str.Add(my_string.Substring(0, i));
            if(str[i] == is_prefix)
                return 1;
        }
        return 0;
    }
}