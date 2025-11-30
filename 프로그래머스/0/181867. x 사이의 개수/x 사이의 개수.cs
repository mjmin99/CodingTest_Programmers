using System;

public class Solution {
    public int[] solution(string myString) {
        string[] strArr = myString.Split('x');
        int[] answer = new int[strArr.Length];
        
        for(int i = 0; i < strArr.Length; i++)
        {
            answer[i] = strArr[i].Length;
        }
        return answer;
    }
}