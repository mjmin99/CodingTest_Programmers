using System;

public class Solution {
    public int solution(string myString, string pat) {

        myString = myString.ToLower();
        pat = pat.ToLower();
        
        if(myString.Contains(pat))
            return 1;
        
        return 0;
    }
}