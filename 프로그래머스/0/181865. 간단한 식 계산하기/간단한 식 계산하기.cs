using System;

public class Solution {
    public int solution(string binomial) {
        string[] input = binomial.Split();
        int answer = 0;
        
        if(input[1] == "+")
        {
            answer = int.Parse(input[0])+int.Parse(input[2]);
        }
        else if(input[1] == "-")
        {
            answer = int.Parse(input[0])-int.Parse(input[2]);
        }
        else if(input[1] == "*")
        {
            answer = int.Parse(input[0])*int.Parse(input[2]);
        }
        
        return answer;
    }
}