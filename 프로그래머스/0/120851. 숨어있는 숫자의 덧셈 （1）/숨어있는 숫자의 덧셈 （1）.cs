using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        
        for(int i =0; i < my_string.Length; i++) // my_string의 모든 글자 확인
        {
            if(Char.IsDigit(my_string[i]) == true) // 모든 글자가 숫자인지 확인
            {
                answer += (int)my_string[i] - 48; // 숫자일 경우 정답에 더하기
            }
            
        }
        return answer;
    }
}