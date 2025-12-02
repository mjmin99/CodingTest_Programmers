using System;

public class Solution {
    public int[] solution(int[] arr, int n) {
        int[] answer = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            answer[i] = arr[i]; // 기본값 복사

            if (arr.Length % 2 == 1) // 배열 길이가 홀수
            {
                if (i % 2 == 0) // 짝수 인덱스
                    answer[i] += n;
            }
            else // 배열 길이가 짝수
            {
                if (i % 2 == 1) // 홀수 인덱스
                    answer[i] += n;
            }
        }

        return answer;
    }
}