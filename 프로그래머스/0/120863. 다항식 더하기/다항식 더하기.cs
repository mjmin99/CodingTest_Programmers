using System;

public class Solution {
    public string solution(string polynomial) {
 
        string[] terms = polynomial.Split(" "); // 모든 다항식을 공백을 기준으로 나눠서 배열로 저장
        int xSum = 0; // x 식의 항
        int numSum = 0; // 정수항
        
        foreach (var term in terms) 
        {
            if (term == "+") continue; // 각항 반복하는데 + 기호는 일단 무시

            if (term.Contains("x")) 
            {
                string coef = term.Replace("x", ""); // x 는 일단 x 제거 해서 숫자만 남기고
                xSum += string.IsNullOrEmpty(coef) ? 1 : int.Parse(coef); // x 합에 저장
            } 
            else 
            {
                numSum += int.Parse(term); // 숫자는 숫자에 저장
            }
        }
        
        string xPart = xSum == 0 ? "" : (xSum == 1 ? "x" : $"{xSum}x"); //x 항이 0과 1인 경우 각각 예외로 처리 그외 숫자는 뒤에 x 붙이기
        string numPart = numSum == 0 ? "" : $"{numSum}"; // 상수항엔 0 일 경우 생략 아니면 그외는 숫자 붙이기

        if (xPart != "" && numPart != "") // 두항이 둘 다 존재하면 x항 + 상수항으로 정리 한쪽만 존재하면 해당 항만 반환
            return xPart + " + " + numPart;
        else if (xPart != "")
            return xPart;
        else
            return numPart;
    }
}