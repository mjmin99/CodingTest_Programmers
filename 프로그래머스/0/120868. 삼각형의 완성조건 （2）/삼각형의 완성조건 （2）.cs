using System;
using System.Linq;

public class Solution {
    public int solution(int[] sides) {
        int a = sides.Max() - sides.Min();
        int b = sides.Max() + sides.Min();
        
        
        int answer = b - a - 1;
        return answer;
    }
}