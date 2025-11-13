using System;

public class Solution {
    public int[] solution(int[,] score) {
        int n = score.GetLength(0); // 학생 수
        double[] avg = new double[n]; // 평균 저장 배열
        int[] answer = new int[n]; // 등수 저장 배열
        
        //. 평균 계산
        for(int i = 0; i < n; i++)
        {
            avg[i] = (score[i,0] + score[i,1]) / 2.0;
        }
      
        // 등수 매기기
        for(int i = 0; i < n; i++)
        {
            int rank = 1;
            for(int j = 0; j < n; j++)
            {
                if(avg[j] > avg[i])
                {
                    rank++;
                }
            }
            answer[i] = rank;
        }
        
        
        return answer;
    }
}