using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        List<int> num = new List<int>();
        num.Add(n);
        while(n != 1) // for 반복문을 사용했었는데 그 보다 while 반복문을 사용하는 것이 훨씬 편함
        {
            //짝일경우
            if(n%2 == 0)
            {
                n = n/2;
                num.Add(n);
            }
            //홀일경우
            else
            {
                n = 3*n+1;
                num.Add(n);
            }
        }
        
        
        int[] answer = num.ToArray();
        return answer;
    }
}