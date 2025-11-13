using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] numlist, int n) {
        int[] answer = numlist
            .OrderBy(x => Math.Abs(x - n))  // n과의 차이 (|x - n|) 기준 오름차순 정렬
            .ThenByDescending(x => x)       // 차이가 같으면 숫자가 큰 값이 앞에 오도록 정렬
            .ToArray();                     // 배열 형태로 전환
        return answer;
    }
}