using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        for(int k = 0; k < queries.GetLength(0); k++)
        {
            int i = queries[k,0];
            int j = queries[k,1];
            
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        return arr;
    }
}
// 이차원 배열에서 int i와 int j 를 저렇게 할당한 이유

// queries [행, 열]
// int i = queries[k, 0];
// int j = queries[k, 1];

// queries[k, 0] → k번째 query의 첫 번째 숫자(i)
// queries[k, 1] → k번째 query의 두 번째 숫자(j)

// 행 \ 열 |  0   1
// ----------------
//    0   |  2   4
//    1   |  0   1
//    2   |  3   2

