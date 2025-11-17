using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        
        string temp = "";
        string temp2 = "";
            
        temp += a.ToString()+b.ToString();
        temp2 += b.ToString()+a.ToString();
                
        int d = Int32.Parse(temp);
        int c = Int32.Parse(temp2);
                
        if(d > c)
        {
            return d;
        }
        else
        {
            return c;
        }
    }
}

//  int a = Int32.Parse(s[0]); 맨날 헷갈리는 정수로 만들기