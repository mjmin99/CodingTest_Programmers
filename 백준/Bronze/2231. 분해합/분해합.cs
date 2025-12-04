using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine()); // 입력 받기
        int result = 0;
        
        // 생성자는 N보다 많아야 60 정도 작다는 점을 이용해서 가능한 모든 수 검사.
        int start = Math.Max(1, N - 60);
        
        
        for(int i = start; i < N; i++ )
        {
            int sum = i;
            int temp = i;
            
            while(temp > 0)
            {
                sum += temp %10;
                temp /= 10;
            }
            // 분해합일 경우 i 가 생성자의 가능성 존재
            if(sum == N)
            {
                result = i;
                break;
                
            }
        }
        Console.WriteLine(result);
    }
    
}