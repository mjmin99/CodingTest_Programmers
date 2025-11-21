public class Solution {
    public int solution(int[] num_list) {
        for (int i = 0; i < num_list.Length; i++)
        {
            if (num_list[i] < 0)
            {
                return i; // 첫 음수의 인덱스 즉시 반환
            }
        }
        return -1; 
    }
}