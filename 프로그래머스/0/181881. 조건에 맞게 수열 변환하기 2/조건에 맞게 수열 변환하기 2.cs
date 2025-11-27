using System;

public class Solution {
    public int solution(int[] arr) {
        int x = 0;

        while (true)
        {
            bool changed = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int before = arr[i];

                if (arr[i] >= 50 && arr[i] % 2 == 0)
                {
                    arr[i] /= 2;
                }
                else if (arr[i] < 50 && arr[i] % 2 == 1)
                {
                    arr[i] = arr[i] * 2 + 1;
                }

                if (before != arr[i])
                    changed = true;
            }

            // 변한 게 없으면 arr(x) == arr(x+1)이므로 return
            if (!changed)
                return x;

            x++;
        }
    }
}
