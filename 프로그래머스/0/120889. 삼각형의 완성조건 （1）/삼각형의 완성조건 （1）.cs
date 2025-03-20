using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        //삼각형 세변을 각각 abc로 재정의
        int a = sides[0]; int b = sides[1]; int c = sides[2];    
        if(a<b+c&&b<a+c&&c<a+b)
            {
                answer = 1;
            }
        else
        {
            answer = 2;
        }
        
        return answer;
    }
}