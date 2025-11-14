using System;

public class Solution {
    public int solution(int[] common) {
        int answer = 0;
        // 등차수열 확인
        if(common[2] - common[1] == common[1] - common[0])
        {
            answer = common[common.Length - 1] + (common[1] - common[0]);
        }
        // 등비수열 확인
        else
        {
            answer = common[common.Length - 1] * (common[1] / common[0]);
        }
        return answer;
    }
}