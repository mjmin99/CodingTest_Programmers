using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string myStr) {
         List<string> result = new List<string>();
        string current = "";
        
        foreach (char c in myStr)
        {
            if(c== 'a' || c== 'b' || c=='c')
            {
                if(current.Length > 0)
                {
                    result.Add(current);
                    current = "";
                }
            }
            else
            {
                current += c;
            }
        }
        // 마지막 문자열 처리
        if (current.Length > 0)
            result.Add(current);

        // 결과가 비었으면 ["EMPTY"]
        if (result.Count == 0)
            return new string[] { "EMPTY" };

        return result.ToArray();
    }
}