using System;
using System.Linq;

public class Solution {
    public int solution(int[,] dots) {
        int length = dots.GetLength(0); // dots 배열 첫번째 차원의 점의 갯수를 받아옴 
        
        // x값과 y값 각각 배열로 추출
        int[] xValues = new int[length]; //x좌표 저장할 배열
        int[] yValues = new int[length]; //y좌표 저장할 배열
        
        
          for (int i = 0; i < length; i++) // 점들을 순회하면서 각 배열안에 집어넣고 
          {
            xValues[i] = dots[i, 0]; // x 좌표 
            yValues[i] = dots[i, 1]; // y 좌표
          }
        
        int width = xValues.Max() - xValues.Min();   // 가로 길이
        int height = yValues.Max() - yValues.Min();  // 세로 길이
        
        
        
        return width * height;
    }
}