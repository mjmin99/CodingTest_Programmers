using System;

public class Solution {
    public int solution(int[,] dots) {
        // dots는 [4, 2] 형태의 2차원 배열

        // 두 점씩 묶어서 가능한 조합은 총 3가지 (교차 형태로)
        // 1. (0,1) & (2,3)
        // 2. (0,2) & (1,3)
        // 3. (0,3) & (1,2)
        
        if (IsParallel(dots, 0, 1, 2, 3)) return 1;
        if (IsParallel(dots, 0, 2, 1, 3)) return 1;
        if (IsParallel(dots, 0, 3, 1, 2)) return 1;

        return 0;
    }
        private bool IsParallel(int[,] dots, int a, int b, int c, int d) {
        int x1 = dots[a, 0], y1 = dots[a, 1];
        int x2 = dots[b, 0], y2 = dots[b, 1];
        int x3 = dots[c, 0], y3 = dots[c, 1];
        int x4 = dots[d, 0], y4 = dots[d, 1];

        // 교차 곱으로 비교 (분모 0 방지)
        return (y2 - y1) * (x4 - x3) == (y4 - y3) * (x2 - x1);
    }
}