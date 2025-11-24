using System;

class akswns
{
    static void Main()
    {
        int[] alphabet = new int[26];
        string input = Console.ReadLine();
        
        for(int i = 0 ; i < 26; i++)
            alphabet[i] = -1;
        
       for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];          // 현재 문자
            int index = c - 'a';        // 알파벳을 0~25로 변환

            if (alphabet[index] == -1)  // 처음 등장한 경우만 기록
                alphabet[index] = i;
        }
        
        for(int i = 0; i < 26; i++)
        {
            Console.Write($"{alphabet[i]} ");
        }
        
    }
}
