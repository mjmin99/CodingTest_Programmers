using System;
using System.Collections.Generic; // 리스트 사용을 위해서

public class Solution {
    public int[] solution(int n) {
        List<int> list = new List<int>(); // 약수는 몇개 있다고 정해지지 않은 거니까 리스트 사용
        
        for(int i = 1; i <= n; i++) // 0을 제외한 1 부터 자기자신까지 약수가 있는지 찾기
        {
            if(n % i == 0) // 나눠떨어진다면 약수로 판정
            {
                list.Add(i); // 리스트에 추가
            }
        }
        
        int[] answer = list.ToArray(); // 리스트를 int 배열로 바꿔서 출력
        return answer;
    }
}