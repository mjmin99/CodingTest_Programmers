using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] rank, bool[] attendance) {
        int n = rank.Length;
        var list = new List<(int r, int idx)>();

        for (int i = 0; i < n; i++) {
            if (attendance[i]) {
                list.Add((rank[i], i));
            }
        }

        list.Sort((x, y) => x.r.CompareTo(y.r));  // 등수 기준 정렬

        int a = list[0].idx;
        int b = list[1].idx;
        int c = list[2].idx;

        return 10000 * a + 100 * b + c;
    }
}