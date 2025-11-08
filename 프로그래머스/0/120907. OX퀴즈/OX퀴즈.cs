using System;

public class Solution {
    public string[] solution(string[] quiz) {
        string[] answer = new string[quiz.Length]; // 문제가 하나가 아니라서 문제 하나당 검사하기 위해
        
        for(int i = 0; i < quiz.Length; i++) // 배열에 담긴 문제가 하나가 아니니까 한 문제씩 돌려보기
        {
            answer[i] = oxCheck(quiz[i].Split(" ")); // 아래서 만든 문제를 함수를 이용해서 한 문제씩 반복
        }
        return answer; 
    }
    
    public string oxCheck(string[] str) // 하나의 수식씩 나누어서 검사
    {
        int num = int.Parse(str[0]); // 첫 번째 숫자는 정수로 변환
        
        for(int i = 1; i < str.Length; i++) // 배열의 모든 길이만큼 반복
        {
            if(i % 2 != 0) // +, -, = 인 경우
            {
                if(str[i].Equals("+")) // + 일때
                {
                    num += int.Parse(str[i + 1]); // 넘버에 숫자를 더해
                }
                else if(str[i].Equals("-")) // - 일때
                {
                    num -= int.Parse(str[i + 1]); // 넘버에 숫자를 빼
                }
                else // = 일때
                {
                    if(int.Parse(str[i + 1]) == num) // 여즉 더한게 num 과 맞는지 비교
                    {
                        return "O"; // 맞으면 O
                    }
                    else
                    {
                        return "X"; // 틀리면 X 
                    }
                }
            }
        }
        
        return "아무말이나 적어도 됨 ㅋ 차피 위에서 O나 X 둘 중 하나는 확실히 나옴 ㅋ";
    }
}