using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[queries.GetLength(0)];
        
        for(int q = 0; q <queries.GetLength(0); q++)
        {
            int s = queries[q,0];
            int e = queries[q,1];
            int k = queries[q,2];
            
            for(int i = s; i <= e; i++)
            {
                if(i % k == 0)
                {
                    arr[i]++;
                }
            }
            
        }
            
        return arr;
    }
}