using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_str, int n) {
        List<string> result = new List<string>(); // 결과를 저장할 list 생성
        
        for(int i= 0; i < my_str.Length; i+=n) // 문자열의 처음부터 끝까지 n 씩 건너뛰면서 반복 / i는 현재 자르기 시작할 위치
        {
            int length = Math.Min(n, my_str.Length - i); //자를 길이 계산 
            result.Add(my_str.Substring(i, length));
        }
        
        
        
        
        return result.ToArray();
    }
}