using System;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
        int temp = i; // a 의 자릿수 분석할 때 임시로 쓰는 변수
            
        for(int a = i; a <= j; a++) // i 부터 j 까지 숫자를 하나씩 가져와서 검사
        {
            temp = a; // 현재 숫자 저장
            while(temp > 0) // temp가 0이 될 때까지 각 자릿수를 하나씩 검사함
            {
                if(temp % 10 == k) //현재 자릿수가 k와 같다면 등장 횟수 증가
                {
                    answer++;
                }
                temp /= 10; // temp를 한 자릿수 줄임
            }
        }
        return answer;
    }
}
// 이건 수학적으로 사고가 어려웠음