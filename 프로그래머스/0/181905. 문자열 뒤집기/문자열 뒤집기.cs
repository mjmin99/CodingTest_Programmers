using System;

public class Solution {
    public string solution(string my_string, int s, int e) {
    
        char[] arr = my_string.ToCharArray(); // 문자배열로 만들기
        
        while(s < e)
        {
            char temp = arr[s];
            arr[s] = arr[e];
            arr[e] = temp;
            s ++;
            e --;
        }
        string answer = new string(arr);
        return answer;
    }
}