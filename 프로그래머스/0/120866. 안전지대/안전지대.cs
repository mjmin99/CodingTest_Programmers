using System;

public class Solution {
    public int solution(int[,] board) {
        int answer = 0;
        int length = board.GetLength(0); // 정사각형 보드니까 1번째 차원의 
        
        // 상하좌우 대각선 8방향 표현 배열
        //인덱스 k가 같을 때, x[k], y[k]는 방향 쌍 (예: k = 0이면 위쪽 (-1, 0), k = 4는 좌상단 (-1, -1))
        int[] x = new int[8]{-1, 1, 0, 0, -1, -1, 1, 1};
        int[] y = new int[8]{0, 0, -1, 1, -1, 1, -1, 1};
        
        // 주어진 보드 만큼의 임시 보드
        int[,] temp = new int[length,length]; 
        
        // 좌표를 계산할 임시 변수
        int nx = 0;
        int ny = 0;
        
        // 지뢰 주변 또한 위험지역으로 표시
        for(int i = 0; i < length; i++)
        {
            for(int j = 0; j < length; j++)
            {
                if(board[i,j] == 1)
                {
                    temp[i,j] = 1;
                    for(int k = 0; k < 8; k++) // 지뢰 기준 8방향을 순회하면서 범위내 좌표면 위험지역으로 표시
                    {
                        nx = i + x[k];
                        ny = j + y[k];
                        if(nx >= 0 && nx < length && ny >= 0 && ny < length)
                        {
                            temp[nx,ny] = 1;
                        }
                    }
                }
            }
        }
                    
        // 위험지역 아닌 칸만 세기
        for(int i = 0; i < length; i++) 
        {
            for(int j = 0; j < length; j++)
            {
                if(temp[i,j] != 1)
                {
                    answer++;
                }
            }
        }   
        return answer;
    }
}