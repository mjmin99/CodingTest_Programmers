using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) {
        List<string> str = new List<string>();
        
        for(int i =0; i < my_string.Length; i++)
        {
            str.Add(my_string.Substring(i));
        }

        str.Sort();
        
        return str.ToArray();
    }
}