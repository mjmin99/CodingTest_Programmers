using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = 0;
        int ball = 1; // 첫번째에서 시작하니까
        
        for(int i = 0; i< k-1; i++) //공이 k 번 만큼 움직인다는 설정
        {
            if(ball + 2 > numbers.Length) // 공이 한 번 건너뛰었을때 인원수보다 많아진다면
            {
                ball += 2 ;
                ball -= numbers.Length;
            }
            else
            {
                ball += 2;
            }
        }
        answer = ball;
        return answer;
    }
}