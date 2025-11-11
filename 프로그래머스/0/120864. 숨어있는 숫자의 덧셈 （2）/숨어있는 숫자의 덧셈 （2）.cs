using System;

public class Solution {
    public int solution(string my_string) {
         my_string += "K"; // 문자열에 K 를 더해 마지막 자리라는 것을 알려줌
        
        int answer = 0;
        int save = 0; // 현재 연속된 숫자를 숫자로 변환해서 저장하는 변수
        
        for(int i = 0; i < my_string.Length; i++) // 문자열 전체 순회
        {
            if(char.IsDigit(my_string[i]) == true) 
            {
                save = save * 10 + ((int)my_string[i] - 48); // 연속된 숫자를 십의 자리단위로 올린 후 더하는 식
            }
            else
            {
                answer += save; // 정답에 더해놓기
                save = 0; // 세이브 초기화
            }
        }
        
        return answer;
    }
}