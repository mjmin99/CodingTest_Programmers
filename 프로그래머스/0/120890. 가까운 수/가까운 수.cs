using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        int num = 100;
        Array.Sort(array); // 오름 차순 배열 정렬
        
        for(int i = 0; i < array.Length; i++) // 배열의 모든 정수에 대해서 반복
        {
            if(Math.Abs(array[i] - n) < num) // n과의 차이가 현재까지의 최소 차이보다 작으면 
            {
                num = Math.Abs(array[i] - n); // 새로운 최소 차이 저장
                answer = array[i];          //그때의 배열 값을 결과로 저장
            }
        }
        
        return answer;
    }
}