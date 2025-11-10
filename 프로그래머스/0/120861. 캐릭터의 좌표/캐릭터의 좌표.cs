using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
        int x = 0, y = 0; // 일단 현재 좌표를 담을 변수 생성

        int maxX = board[0] / 2; // 맵의 최대 범위 지정
        int maxY = board[1] / 2; 

        foreach (string key in keyinput) { // keyinput 배열 수 만큼 반복
            switch (key) {
                case "up":  // 위
                    if (y < maxY) y++;
                    break;
                case "down": // 아래
                    if (y > -maxY) y--;
                    break;
                case "left": // 왼쪽
                    if (x > -maxX) x--;
                    break;
                case "right": // 오른쪽 
                    if (x < maxX) x++;
                    break;
            }
        }

        return new int[] { x, y };
    }
}