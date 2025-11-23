using System;

public class Solution {
    public int[] solution(string my_string) {
        
        // 길이 52 배열 생성
        // 0~25 : 'A' ~ 'Z'
        // 26~51 : 'a' ~ 'z'
        int[] answer = new int[52];
        
        // 문자열을 처음부터 끝까지 하나씩 검사
        foreach(char ch in my_string)
        {
            // 대문자 A~Z 인 경우
            if(ch>= 'A' && ch <= 'Z')
            {
                // 예: ch = 'C'
                // 'C' - 'A' = 2 → 배열의 2번 칸 증가
                answer[ch -'A']++;
            }
            // 소문자 a~z 인 경우
            else if (ch >= 'a' && ch <= 'z')
            {
                // 예: ch = 'c'
                // 'c' - 'a' = 2 → 여기에 +26을 해서 소문자 영역으로 이동
                // 소문자 'a'는 index 26, 'b'는 index 27 ... 'z'는 index 51
                answer[(ch - 'a') + 26]++;
            }
        }
        
        
        return answer;
    }
}


// C#에서 char는 내부적으로 정수(ASCII/유니코드 값) 로 계산할 수 있습니다.
//예:

// 'A' = 65

// 'B' = 66

// 'a' = 97

// 'b' = 98

// 그래서 'C' - 'A' = 2 같은 계산이 가능합니다.
