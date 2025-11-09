using System;

public class Solution {
    public int solution(int[] array) {
        int count = 0; // 7셀 변수
        
        foreach (int number in array)
        {
            count += CountSevens(number);
        }
        return count;
        
    }
        
        
        public int CountSevens(int num)
        {
            int count = 0;
            
            while(num > 0)
            {
                if(num % 10 == 7) count++;
                num /= 10;
            }
            
            return count;
        }
    }
