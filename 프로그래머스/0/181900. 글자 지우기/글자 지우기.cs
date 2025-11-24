using System;

public class Solution {
    public string solution(string my_string, int[] indices) {
        Array.Sort(indices);  // 인덱스 배열 정렬
        string answer = "";
        int index = 0;
        
        for(int i = 0; i < my_string.Length; i++)
        {
            if(index < indices.Length && i == indices[index])
            {
                index++;
                continue;
            }
            answer += my_string[i];
        }
        
        
        return answer;
    }
}