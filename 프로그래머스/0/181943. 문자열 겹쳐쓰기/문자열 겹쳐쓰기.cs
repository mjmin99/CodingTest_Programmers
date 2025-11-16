using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
        
        // 문자열을 자르고 합쳐서 새 문자열 만들기
        string answer = my_string.Substring(0, s) + overwrite_string;
        
        // 만약 더 길다면
        if(s + overwrite_string.Length < my_string.Length)
        {
            // 긴만큼 추가하기
            answer += my_string.Substring(s + overwrite_string.Length);
        }
       
        return answer;
    }
}

// Substring(a, b) 함수에 대해
// a는 시작인덱스 , b는 잘라낼 문자 수

// 예시코드
// string text = "Hello, World!";
// string result = text.Substring(7, 5);
// 
// Console.WriteLine(result);  // 출력: World

// H  e  l  l  o  ,     W  o  r  l  d  !
// 0  1  2  3  4  5  6  7  8  9 10 11 12



//using System;
//
//public class Solution {
//    public string solution(string my_string, string overwrite_string, int s) {
//        string answer = "";
//        int a = 0;
//        
//        for(int i = 0; i < my_string.Length; i++)
//        {
//            if(i < n)
//            {
//                continue;
//            }
//            else
//            {
//                my_string[i] = overwrite_string[a];
//                a++;
//            }
//        }
//        return answer;
//    }


// 이 코드에서 오류가 나는 이유는 C#에서 문자열(string)은 immutable(불변) 이기 때문입니다. 즉, 문자열의 개별 문자에 접근하여 직접 수정할 수 없습니다.
// 그런데 이 코드에서는 다음과 같은 라인을 통해 문자열의 값을 직접 수정하려고 하고 있습니다: