using System;
using System.Collections.Generic; // HashSet 쓰려면 필수!
using System.Text;   // StringBuilder 사용

class akswns
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        
        HashSet<int> set = new HashSet<int>();    //해쉬셋 만들고
        
        for(int i = 0; i < N; i++)              //해쉬셋에 집어넣었음
        {
            set.Add(int.Parse(input[i]));
        }
        
        int M = int.Parse(Console.ReadLine());
        string[] input2 = Console.ReadLine().Split();

        StringBuilder sb = new StringBuilder(); // 출력 버퍼
        
        // M개의 수 각각에 대해 set 안에 있는지 확인
        for(int i = 0; i < M; i++)
        {
            int x =int.Parse(input2[i]);
                
            if(set.Contains(x))
                sb.AppendLine("1");
            else
                sb.AppendLine("0");;
        }
        
        Console.Write(sb.ToString());   // 반드시 출력해야 함
    }
}


/*
HashSet<T> 는 “집합(set)” 자료구조

특징:

중복을 허용하지 않음 → 같은 값 넣으면 한 번만 저장됨

순서가 없음 → 저장 순서 보장 안 됨

특정 값이 들어있는지 확인할 때 (Contains) 엄청 빠름 → 평균 O(1)


-------------------------------------------------------
처음엔 이중 for문으로 짜려고 했음
그럼 최악 O(N × M) → 100,000 × 100,000 = 10¹⁰ → 시간 초과 확정




 ++++
스트링 빌더를 사용하지 않고 그냥 출력하니 시간초과 이슈로 인해 스트링 빌더 사용



*/