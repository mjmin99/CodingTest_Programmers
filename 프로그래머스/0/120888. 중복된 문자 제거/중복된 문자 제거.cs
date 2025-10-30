using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        string answer = string.Concat(my_string.Distinct());
        // 링큐로 금방 품 Distinct()로 중복제거, Concat로 문자열 연결
        return answer;
    }
}