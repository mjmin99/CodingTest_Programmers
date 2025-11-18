using System;

public class Solution {
    public string solution(string code) {
        string answer = "";
        int mode = 0;
        
        for(int i = 0; i < code.Length; i++)
        {
            if(code[i] == '1')
            {
                if(mode == 0)
                    mode = 1;
                else
                    mode = 0;
                
            }
            
            else if(i % 2 == 0 && mode == 0)
                answer += code[i];
            
            else if(i % 2 != 0 && mode == 1)
                answer += code[i];
            
            Console.WriteLine(mode);
        }
        
        if(string.IsNullOrEmpty(answer))
                answer = "EMPTY";
        
        return answer;
    }
}

// 난해한데??