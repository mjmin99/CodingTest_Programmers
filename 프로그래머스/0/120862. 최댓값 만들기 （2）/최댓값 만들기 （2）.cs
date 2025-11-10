using System;

public class Solution {
    public int solution(int[] numbers) {
        
        Array.Sort(numbers); // 배열 정렬 ㅋ C# 뚝딱 ㅋ
        int n = numbers.Length; // n은 배열의 길이 저장
        
        int max1 = numbers[0] * numbers[1]; // 가장 첫 수 곱
        int max2 = numbers[n - 1] * numbers[n - 2]; // 가장 마지막 수 곱
        
        
        return Math.Max(max1, max2); // 둘 중 큰거 제출
    }
}