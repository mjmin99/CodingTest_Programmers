using System;

public class Solution {
    public string solution(string a, string b) {

        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;
        string result = "";

        while (i >= 0 || j >= 0 || carry > 0) {
            int x = (i >= 0) ? a[i] - '0' : 0;
            int y = (j >= 0) ? b[j] - '0' : 0;

            int sum = x + y + carry;
            result = (sum % 10) + result;  // 앞에 붙여서 결과를 만듦
            carry = sum / 10;

            i--;
            j--;
        }

        return result;
    }
}
