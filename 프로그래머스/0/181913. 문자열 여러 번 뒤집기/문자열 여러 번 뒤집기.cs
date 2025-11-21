using System;

public class Solution {
    public string solution(string my_string, int[,] queries) {
        char[] arr = my_string.ToCharArray(); // 문자 배열로 변환

        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int s = queries[i, 0];
            int e = queries[i, 1];

            // 구간 [s, e] 뒤집기 (투 포인터)
            while (s < e)
            {
                char temp = arr[s];
                arr[s] = arr[e];
                arr[e] = temp;
                s++;
                e--;
            }
        }

        return new string(arr);
    }
}