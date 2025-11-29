using System;

public class Solution {
    public string solution(string myString, string pat) {
        int idx = myString.LastIndexOf(pat);
        
        return myString.Substring(0, idx + pat.Length);
    }
}