public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string str = "";
        
        for(int i = 0; i < babbling.Length; i++)
        {
            // babbling[i]를 Replace()로 문자열이 있을시 그 문자열을 "x"로 변환
            babbling[i] = babbling[i].Replace("aya", "x");
            babbling[i] = babbling[i].Replace("ye", "x"); 
            babbling[i] = babbling[i].Replace("woo", "x");
            babbling[i] = babbling[i].Replace("ma", "x");
            // babbling[i]를 Replace()로 "x"를 string.Empty로 초기화 
            str = babbling[i].Replace("x", string.Empty);
            // 발음 가능한 문자일시 str은 공백이므로 answer값 증가
            if(str == "")
            {
                answer++;
            }           
        }
        return answer;
    }
}
// 패스 문제