using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        List<string> str = new List<string>();
        
        for(int i = 0; i < my_string.Length; i++ )
        {
            str.Add(my_string.Substring(i));
        }
        for(int j = 0; j < str.Count; j++)
        {
            if(str[j] == is_suffix)
                return 1;
        }
        return 0;
    }
}