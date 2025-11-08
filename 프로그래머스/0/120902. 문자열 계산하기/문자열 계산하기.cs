using System;

public class Solution {
    public int solution(string my_string) {
        string[] str = my_string.Split(" "); // 문자 배열을 만들어서 공백단위로 쪼갠다음 저장
        int answer = int.Parse(str[0]); // 배열의 첫 요소를 정수로 만들어서 저장
        
        for(int i = 1; i <str.Length; i++) // 모든 길이만큼 반복
        {
            if(i % 2 != 0) // 잘못된 입력이 없다면 홀수에 수식 짝수에 숫자일테니
            {
                if(str[i] == "+") // 홀수 일때 + 이면 더하고 
                {
                    answer += int.Parse(str[i+1]); // 정답에 인트 정수 로 바꾸어서 더하기
                }
                else // 마이너스면 빼기
                {
                    answer -= int.Parse(str[i+1]); // 정답에 인트 정수 로 바꾸어서 빼기
                }
            }
        }
        return answer;
    }
}