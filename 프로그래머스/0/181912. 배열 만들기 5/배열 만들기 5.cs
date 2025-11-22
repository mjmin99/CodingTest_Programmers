using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l) {
        List<int> result = new List<int>();
        
        foreach (string str in intStrs)
        {
            // s 인덱스부터 l 길이의 부분 문자열 추출
            string sub = str.Substring(s, l);
            
            // 정수 변환
            int value = int.Parse(sub);

            // k보다 크면 리스트에 추가
            if (value > k)
                result.Add(value);
        }

        return result.ToArray();
    }
}
