using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[queries.GetLength(0)];
        
        for(int i= 0; i < queries.GetLength(0) ; i++) // 이건 정답에 집어넣는 용도
        {
            int s = queries[i,0];
            int e = queries[i,1];
            int k = queries[i,2];
            
            int minValue = int.MaxValue;
            
            for(int j = s; j <= e; j++) //이건  s < i < e 맞추는 용도
            {
                if(arr[j] > k)
                {
                    minValue = Math.Min(minValue, arr[j]);
                }
            }
            
            if(minValue == int.MaxValue)
                answer[i] = -1;
            else
                answer[i] = minValue;
        }
        return answer;
    }
}