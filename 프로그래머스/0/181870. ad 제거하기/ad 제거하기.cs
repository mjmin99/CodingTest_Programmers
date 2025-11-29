using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] strArr) {
        List<string> strs = new List<string>();
        
        foreach(string s in strArr)
        {
            if(!s.Contains("ad"))
            {
                strs.Add(s);
            }
        }
        
        
        return strs.ToArray();
    }
}