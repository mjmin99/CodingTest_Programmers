using System;

public class Solution {
    public int solution(int a, int b, int c, int d) 
    {
        // 네 개가 모두 같은 경우
        if (a == b && b == c && c == d)
        {
            return 1111 * a;
        }

        // 세 개가 같고 하나만 다른 경우
        // aaa b
        if (a == b && b == c && c != d)
        {
            int p = a;
            int q = d;
            return (int)Math.Pow(10 * p + q, 2);
        }
        // aa b a 형태
        if (a == b && b == d && d != c)
        {
            int p = a;
            int q = c;
            return (int)Math.Pow(10 * p + q, 2);
        }
        // a bbb 형태
        if (a == c && c == d && a != b)
        {
            int p = a;
            int q = b;
            return (int)Math.Pow(10 * p + q, 2);
        }
        // bbb a 형태
        if (b == c && c == d && b != a)
        {
            int p = b;
            int q = a;
            return (int)Math.Pow(10 * p + q, 2);
        }

        // 두 개씩 같은 값이 나오는 경우 (2쌍)
        if (a == b && c == d && a != c)
        {
            int p = a, q = c;
            return (p + q) * Math.Abs(p - q);
        }
        if (a == c && b == d && a != b)
        {
            int p = a, q = b;
            return (p + q) * Math.Abs(p - q);
        }
        if (a == d && b == c && a != b)
        {
            int p = a, q = b;
            return (p + q) * Math.Abs(p - q);
        }

        // 한 쌍 + 두 개는 모두 다른 경우
        // aa b c
        if (a == b && a != c && a != d && c != d)
        {
            return c * d;
        }
        // a c a? c와 d 비교
        if (a == c && a != b && a != d && b != d)
        {
            return b * d;
        }
        if (a == d && a != b && a != c && b != c)
        {
            return b * c;
        }
        if (b == c && b != a && b != d && a != d)
        {
            return a * d;
        }
        if (b == d && b != a && b != c && a != c)
        {
            return a * c;
        }
        if (c == d && c != a && c != b && a != b)
        {
            return a * b;
        }

        // 모두 다른 숫자
        int min = Math.Min(Math.Min(a, b), Math.Min(c, d));
        return min;
    }
}