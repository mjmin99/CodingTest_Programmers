using System;

public class Solution {
    public string solution(string my_string, int[] index_list) {
        string answer = "";
        
        for(int i = 0; i < index_list.Length; i++)
        {
            int a = index_list[i];
            answer += my_string[a];
        }
        return answer;
    }
}