using System;

public class Solution {
    public int[] solution(int[] arr) {
        int x = 1; // 1승 부터 시작
        
        while(x < arr.Length) // x 가 arr.Length 보다 작다면 1승 추가~
        {
            x *= 2; 
        }

        int[] answer = new int[x]; // 최소의 길이인 x 승 만큼의 배열로 만들기
        
        for(int i = 0; i< x; i++)
        {
            if(i < arr.Length)
            {
                answer[i] = arr[i];
            }
            else
            {
                answer[i] = 0;
            }
        }
        
        
        return answer;
    }
}