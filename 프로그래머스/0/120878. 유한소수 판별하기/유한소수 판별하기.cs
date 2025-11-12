using System;

public class Solution {
    public int solution(int a, int b) {
        // 1. 최대공약수로 기약분수 만들기
        int gcd = GCD(a, b);
        b /= gcd;

        // 2. 분모에서 2와 5를 제거
        while (b % 2 == 0) b /= 2;
        while (b % 5 == 0) b /= 5;

        // 3. 남은 수가 1이면 유한소수, 아니면 무한소수
        return (b == 1) ? 1 : 2;
    }

    // 최대공약수 (유클리드 호제법)
    private int GCD(int x, int y) {
        while (y != 0) {
            int temp = x % y;
            x = y;
            y = temp;
        }
        return x;
    }
}