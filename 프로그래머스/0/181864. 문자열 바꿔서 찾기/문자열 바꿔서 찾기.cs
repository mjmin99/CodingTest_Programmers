using System;

public class Solution {
    public int solution(string myString, string pat) {

        char[] arr = pat.ToCharArray();
        
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 'A') arr[i] = 'B';
            else arr[i] = 'A';
        }
        string _pat = new string(arr);
        
        return myString.Contains(_pat) ? 1 : 0;

    }
}