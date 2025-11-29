using System;

public class Solution {
    public int solution(string myString, string pat) {
        int count = 0; // 몇 번 나오나 세는 용도
        
        int pLen = pat.Length;
        int mLen = myString.Length;
        
        for(int i = 0; i <= mLen - pLen; i++)
        {
            if(myString.Substring(i,pLen) == pat)
            {
                count++;
            }
        }
        
        return count;
    }
}