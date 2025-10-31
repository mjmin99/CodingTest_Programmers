using System;

public class Solution {
    public string solution(string cipher, int code) {
        string answer = "";
        
        for(int i = 1; i <= cipher.Length; i++) // 배열 길이만큼 탐색
        {
            if(i % code == 0) // i 번째 글자가 code 의 배수일 경우에만
            {
                answer += cipher[i-1]; // 정답에 추가 배열은 0 번 부터 시작이라 -1 해주기
            }
        }
        return answer;
    }
}