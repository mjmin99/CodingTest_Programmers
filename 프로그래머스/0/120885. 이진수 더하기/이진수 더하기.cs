using System;

public class Solution {
    public string solution(string bin1, string bin2) {
        int num1 = Convert.ToInt32(bin1, 2); // 이진수 → int
        int num2 = Convert.ToInt32(bin2, 2);

        int sum = num1 + num2;
        
        return Convert.ToString(sum, 2);  // int → 이진수 문자열
    }
}