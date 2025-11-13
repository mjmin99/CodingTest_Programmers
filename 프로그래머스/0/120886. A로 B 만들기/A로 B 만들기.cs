using System;

public class Solution {
    public int solution(string before, string after) {
        char[] a = before.ToCharArray();
        char[] b = after.ToCharArray();

        Array.Sort(a);
        Array.Sort(b);

    return (new string(a) == new string(b)) ? 1 : 0;
    }
}