using System;

public class Solution {
    public int[] solution(int num, int total) {
    int start = total / num - (num - 1) / 2; // 토탈을 넘만큼 나누고 앞뒤로 넘만큼 빼고 더해줘서
    int[] answer = new int[num]; // 주어진 수만큼의 배열을 만들기

    for (int i = 0; i < num; i++) {
        answer[i] = start + i; // 첫 숫자부터 반복문으로 집어넣기
    }
        return answer;
    }
}