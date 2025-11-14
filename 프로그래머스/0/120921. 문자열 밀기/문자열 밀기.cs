using System;

public class Solution {
    public int solution(string A, string B) {
        int answer = (B + B).IndexOf(A);        // 문자열을 돌리지 말고 그냥 앞뒤로 2개 붙이고 
        // IndexOf(A) 함수는 A가 B+B 안에서 어떤 위치에 처음으로 등장하는지 반환
        return answer;
    }
}