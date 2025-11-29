using System;

public class Solution {
    public string[] solution(string my_string) {
        return my_string.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
    }
}