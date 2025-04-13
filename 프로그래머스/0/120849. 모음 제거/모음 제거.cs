using System;

public class Solution {
    public string solution(string my_string) {
        string answer = my_string;
        string vowels = "aeoiuAEOIU";
        foreach(char vowel in vowels)
        {
            answer = answer.Replace(vowel.ToString(),"");
        }
        return answer;
    }
}