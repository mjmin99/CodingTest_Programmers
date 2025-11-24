using System;

class akswns
{
    static void Main()
    {
        // 10개의 입력을 저장하는 배열
        int[] input = new int[10];

        // 입력받고 42로 나눈 나머지를 저장
        for (int i = 0; i < 10; i++)
        {
            input[i] = int.Parse(Console.ReadLine()) % 42;
        }

        // 서로 다른 나머지 개수를 카운트하는 변수
        int count = 0;

        // 0부터 41까지의 모든 가능한 나머지 값 검사
        for (int mod = 0; mod < 42; mod++)
        {
            bool exists = false;  // mod 값이 input 안에 존재하는지 표시

            // input 배열 내부에서 mod와 같은 값이 있는지 찾기
            for (int j = 0; j < 10; j++)
            {
                if (input[j] == mod)
                {
                    exists = true;   // 나머지 mod가 존재함
                    break;           // 찾았으니 더 이상 돌 필요 없음
                }
            }

            // mod 값이 하나라도 존재했다면 서로 다른 나머지 개수 +1
            if (exists)
                count++;
        }

        // 최종적으로 서로 다른 나머지가 몇 개인지 출력
        Console.WriteLine(count);
    }
}