using System;

public class Solution {
    public int[] solution(int[] arr) {
        int start = -1;
        int end = -1;
        
        // 배열 전체를 순회하며 값이 2인 위치의 최소/최대 인덱스를 기록
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] == 2)
            {
                if(start == -1) 
                {
                    start = i; // 첫 발견
                }
                end = i; // 마지막 발견(계속 갱신)
            }
        }

        // 2가 한 번도 없는 경우
        if(start == -1)
        {
            return new int[] { -1 };
        }

        // 필요한 최소 구간 길이
        int interval = end - start + 1;

        int[] answer = new int[interval];

        // 해당 구간을 복사
        for(int i = 0; i < interval; i++)
        {
            answer[i] = arr[start + i];
        }

        return answer;
    }
}