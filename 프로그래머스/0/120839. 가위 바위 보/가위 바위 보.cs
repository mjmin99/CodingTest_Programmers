using System;
using System.Linq;

public class Solution {
    public string solution(string rsp) {
        string answer = rsp;
        
        // string.Concat() : 여러 문자를 하나의 문자열로 연결
        // Select() : 문자열의 각 문자(x)를 하나씩 변환
        
        answer = string.Concat(
        rsp.Select(x =>
                  x == '2' ? '0' :
                   x == '0' ? '5' :
                   '2'
                  )
        );
        
        return answer;
    }
}