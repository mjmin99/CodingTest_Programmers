using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] s1, string[] s2) {
        int answer = 0;
        
        // 해쉬셋으로 풀어보겠음
        //  for (int i = 0; i < s1.Length; i++) { 
        //     for (int j = 0; j < s2.Length; j++) {
        //         if (s1[i] == s2[j]) {
        //             answer++;
        //         }
        //     }
        // }
        
        HashSet<string> set = new HashSet<string>(s1);
        int count = 0;
        
        foreach (string item in s2)
        {
            if(set.Contains(item)) count++;
        }
        
        
        answer = count;
        
        return answer;
    }
}