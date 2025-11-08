using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        List<int> asas = new List<int>();
        
        for(int i = 0; i < numlist.Length; i++)
        {
            if(numlist[i] % n ==0)
            {
                asas.Add(numlist[i]);
            }
        }
        int[] answer = asas.ToArray();
        return answer;
    }
}