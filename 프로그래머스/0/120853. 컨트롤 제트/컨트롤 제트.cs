using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        string[] arr = s.Split(" "); // 문자열 s 의 공백을 기준으로 나누어서 문자열배열 arr에 저장하기
        int index = 0; // 최근 숫자의 위치를 기억할 인덱스로 사용할 변수 생성
        
        for(int i = 0; i<arr.Length; i++) //arr 배열의 모든 수 만큼 검사
        {
            if(arr[i] == "Z") // Z 인 경우
            {
                if(index == 0) // 인덱스가 0이면 이전 숫자가 없을테니 넘어가기 // 맨 처음부터 Z 가 나올 수 있다는 가정의 예외 방어 코드
                {
                    continue; // 그냥 다음 반복으로 넘어가기
                }
                index--; // 인덱스를 1 감소시켜서 이전 숫자로 이동
                answer -= int.Parse(arr[index]); //정답에 
            }
            else //숫자인 경우
            {
                answer += int.Parse(arr[i]); //arr[i]에 해당하는 문자를 int 자료형으로 변환하고 정답에 더한다.
                index = i + 1; // 다음 숫자 위치를 기억할 수 있도록 인덱스 갱신
            }
        }
        
        return answer;
    }
}