using System;

class Program
{
    static void Main()
    {
        string[] nm = Console.ReadLine().Split();
        int N = int.Parse(nm[0]); // 보드의 세로
        int M = int.Parse(nm[1]); // 보드의 가로 입력 받기
        
        // 보드의 2차원 char 배열 만들기
        char[,] board = new char[N, M];

        // 보드 입력 받기
        for (int i = 0; i < N; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < M; j++)
            {
                board[i, j] = line[j];
            }
        }
        
        int answer = 64; // 최대 64칸을 다 다시 칠하는 경우니까 충분히 큰 값
        
        
        // (i, j)로 모든 8x8 보드의 시작점을 잡고 검사
        for (int i = 0; i <= N - 8; i++)
        {
            for (int j = 0; j <= M - 8; j++)
            {
                int repaintW = 0; // (0,0)이 'W'로 시작한다고 가정한 경우
                int repaintB = 0; // (0,0)이 'B'로 시작한다고 가정한 경우

                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        char current = board[i + x, j + y];

                        // 현재 좌표가 (x+y) 짝수 → 시작색과 동일해야 함
                        if ((x + y) % 2 == 0) // (x+y)%2 로 위치의 색을 결정
                        {
                            if (current != 'W') repaintW++; 
                            if (current != 'B') repaintB++;
                        }
                        else
                        {
                            if (current != 'B') repaintW++;
                            if (current != 'W') repaintB++;
                        }
                    }
                }

                int localMin = Math.Min(repaintW, repaintB); // 검은 시작과 흰 시작 중 작은 수 선택
                if (localMin < answer)
                    answer = localMin;
            }
        }

        Console.WriteLine(answer);
    }
}