using System;
using System.Linq;

class akswns
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        
        string[] words = new string[N];
        
        for(int i = 0; i < N; i++)
        {
            words[i] = Console.ReadLine();
        }
        
        var result = words
            .Distinct()                       // 1. 중복 제거
            .OrderBy(w => w.Length)           // 2. 길이 기준 정렬
            .ThenBy(w => w)                   // 3. 사전 순 정렬
            .ToList();

        foreach (var w in result)
        {
            Console.WriteLine(w);
        }
        
    }
}