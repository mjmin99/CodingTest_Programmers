using System;

public class Solution {
    public string solution(string[] id_pw, string[,] db) {
        string inputId = id_pw[0]; // 아이디를 담고
        string inputPw = id_pw[1]; // 비밀번호를 담고
        
        int len = db.GetLength(0);
        
        for(int i = 0; i < len; i++)
        {
            string dbId = db[i,0];
            string dbPw = db[i,1];
            
            // 아이디 일치 검사
            if(dbId == inputId)
            {
                // 비번 검사
                if(dbPw == inputPw)
                {
                    return "login";
                }
                else
                {
                    return "wrong pw";
                }
            }
        }
        
        return "fail";
    }
}