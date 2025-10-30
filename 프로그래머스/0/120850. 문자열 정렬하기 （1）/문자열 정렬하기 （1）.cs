using System;
using System.Collections.Generic; //list 사용할거니까 추가

public class Solution {
    public int[] solution(string my_string) {
        List<int> list = new List<int>(); // 문자열안에 숫자가 얼마나 있을지 모르니까 가변이 가능한 리스트로
        
        for(int i = 0; i < my_string.Length; i++) // mu_string의 모든 문자 확인 
        {
            if(char.IsDigit(my_string[i]) == true) // my_string[i]가 숫자인지 판별 a는 false / 3은 true
            {
                list.Add((int)my_string[i] - 48); // 숫자만 추가 근데 아스키코드 값으로 해줘야하기 때문에 -48 해준것 / 0 = 48, 1 = 49, 9 = 57
                //ex => '3' → (int)'3' - 48 = 51 - 48 = 3
            }
        }
        int[] answer = list.ToArray(); // 리스트를 배열로 바꾸기 위해 ToArray()
        Array.Sort(answer); // 오름차순 정렬을 위해 Sort
        return answer;
    }
}