using System;

class akswns
{
    static void Main()
    {
        while(true)
        {
        string[] input = Console.ReadLine().Split();
            
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);
        
        if(a==0 && b==0 && c==0) // 종료조건
            break;
 // 변 길이 정렬 (오름차순)
            int[] arr = { a, b, c };
            Array.Sort(arr);

            // arr[2]가 가장 긴 변
            if (arr[0] * arr[0] + arr[1] * arr[1] == arr[2] * arr[2])
                Console.WriteLine("right");
            else
                Console.WriteLine("wrong");
        }
    }
}

// 내가 틀린 이유는 문자열 배열정렬을 통해 사전 순 배열을 해버렸기 때문 ex 10 , 2 , 5
// 정수로 변환한뒤 정수배열 정렬을 했어야한다,
