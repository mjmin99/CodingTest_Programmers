using System;
using System.Collections.Generic; // list 사용을 위해
using System.Linq; // Distinct(), ToArray() 사용을 위해

public class Solution {
    public int[] solution(int n) {
        List<int> list = new List<int>(); //소인수가 얼마나 있을지 모르니까 가변적인 list 사용
        
        for(int i = 2; i<= n; i++) // 2부터 n까지 모든 수를 검사 // 1은 소인수 아니니까 제외
        {
            while(n % i == 0) // i가 n의 소인수인지 검사 근데 나누어 떨어질 수 있다면 계속 나누기
            {
                list.Add(i);
                n/=i; // 계속 나눠서 나눈 값 업데이트 해주기
            }
        }
        int[] answer = list.Distinct().ToArray(); // 중복원소 제거, 리스트 배열로 반환하기
        
        return answer;
    }
}