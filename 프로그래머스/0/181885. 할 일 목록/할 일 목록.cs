using System;

public class Solution {
    public string[] solution(string[] todo_list, bool[] finished) {
        int len = 0;
        
        for(int i = 0; i < finished.Length; i ++)
        {
            if(finished[i] == false)
            {
                len++;
            }
        }
        
        string[] answer = new string[len];
        int idx = 0;
        
        for(int i = 0; i < finished.Length; i++)
        {
            if(!finished[i])
            {
                answer[idx] = todo_list[i];
                idx++;
            }
        }
        return answer;
    }
}