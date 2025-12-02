using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] strArr) {
        Dictionary<int, int> groups = new Dictionary<int, int>();
        
        // 길이별로 개수 세기
        
        foreach(string s in strArr)
        {
            int len = s.Length;
            
            if(!groups.ContainsKey(len))
            {
                groups[len] = 1;
            }
            else
            {
                groups[len]++;
            }
        }
        
        int max = 0;
        foreach (int count in groups.Values)
        {
            if(count > max)
                max = count;
        }
        
        

        return max;
    }
}