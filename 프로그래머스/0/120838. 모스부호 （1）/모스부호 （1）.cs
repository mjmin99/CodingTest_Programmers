using System;

public class Solution {
    public string solution(string letter) {
        string answer = "";
        
        // 공백을 기준으로 한 문자씩 분리
        
        string[] mos = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
        
        foreach(string a in letter.Split(" "))
        {
            // 알파벳은 아스키코드 97('a')부터 시작하므로
            // 인덱스 + 97을 문자로 변환하면 대응되는 알파벳을 얻을 수 있음
            // 예: Convert.ToChar(7 + 97) → 'h'
            answer += Convert.ToChar(Array.IndexOf(mos, a) + 97);
            
            // Array.IndexOf(mos, a)
            // → mos 배열에서 문자열 a(모스부호)가 몇 번째 인덱스인지 찾음
            // 예: "...." → 인덱스 7 (0부터 시작)
        }
        
        return answer;
    }
}