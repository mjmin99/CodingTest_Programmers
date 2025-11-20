using System;
using System.Collections.Generic; // List 쓰기 위해서

public class Solution {
    public int[] solution(int l, int r) {
        List<int> list = new List<int>(); // 가변 배열이니까

        // l부터 r사이 수 검사
        for (int x = l; x <= r; x++)
        {
            if (IsZeroFive(x)) // 참이면 리스트에 추가
                list.Add(x);
        }

        if (list.Count == 0)
            return new int[] { -1 }; // 리스트에 들어있는게 아무것도 없으면 -1 반환

        // 결과를 배열로 만들어서 반환
        return list.ToArray(); // ※ 작은수부터 넣으니까 정렬 불 필요
    }

    // 숫자 n이 0과 5로 이루어진지 참 거짓을 판정 하는 함수
    bool IsZeroFive(int n)
    {
        foreach (char c in n.ToString())
        {
            if (c != '0' && c != '5')
                return false;
        }
        return true;
    }
}