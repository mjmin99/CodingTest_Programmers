using System;

public class Solution {
    public int solution(int[,] lines) {
        int[] arr = new int[201]; // 좌표 -100 ~ 100 보정

        for (int i = 0; i < 3; i++) {
            int start = Math.Min(lines[i, 0], lines[i, 1]) + 100;
            int end = Math.Max(lines[i, 0], lines[i, 1]) + 100;

            // 선분의 길이만큼 표시 (끝점은 포함 X)
            for (int j = start; j < end; j++) {
                arr[j]++;
            }
        }

        int overlap = 0;
        for (int i = 0; i < arr.Length; i++) {
            // 2개 이상 겹치는 구간만 세기
            if (arr[i] >= 2) {
                overlap++;
            }
        }

        return overlap;
    }
}// 이 문제 모르겠는데?