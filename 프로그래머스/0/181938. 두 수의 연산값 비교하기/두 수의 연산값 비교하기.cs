using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        
        string temp = a.ToString() + b.ToString();
        int ab = Int32.Parse(temp);
        
        if(ab < 2*a*b)
        {
            return 2*a*b;
        }
        else
        {
            return ab;
        }
        
    }
}