using System;

public class Solution {
    public string[] solution(string[] str_list) {
        
        int firstIdx = -1;   // 첫 번째로 등장한 인덱스
        char firstChar = '\0'; // 'l' 또는 'r'

        // 누가 먼저 나오는지 찾기
        for (int i = 0; i < str_list.Length; i++)
        {
            if (str_list[i] == "l" || str_list[i] == "r")
            {
                firstIdx = i;
                firstChar = str_list[i][0];
                break;  // 첫 등장만 보면 된다
            }
        }

        // l 또는 r 둘 다 없는 경우
        if (firstIdx == -1)
            return new string[0];

        // l이 먼저 나온 경우 → 왼쪽 부분을 반환
        if (firstChar == 'l')
        {
            string[] answer = new string[firstIdx];
            for (int i = 0; i < firstIdx; i++)
            {
                answer[i] = str_list[i];
            }
            return answer;
        }

        // r이 먼저 나온 경우 → 오른쪽 부분 반환
        if (firstChar == 'r')
        {
            int len = str_list.Length - firstIdx - 1;
            string[] answer = new string[len];

            for (int i = 0; i < len; i++)
            {
                answer[i] = str_list[firstIdx + 1 + i];
            }

            return answer;
        }

        return new string[0];  // 방어 코드
    }
}