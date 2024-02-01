using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_CodingTest
{
    /*
     TEST1
     행렬의 덧셈은 행과 열의 크기가 같은 두 행렬의 같은 행, 같은 열의 값을 서로 더한 결과가 됩니다. 2개의 행렬 arr1과 arr2를 입력받아, 행렬 덧셈의 결과를 반환하는 함수, solution을 완성해주세요.

    제한 조건
    행렬 arr1, arr2의 행과 열의 길이는 500을 넘지 않습니다.

    입출력 예
    arr1	          arr2	          return
    [[1,2],[2,3]]	[[3,4],[5,6]]	[[4,6],[7,9]]
    [[1],[2]]	    [[3],[4]]	    [[4],[6]]
     */

    internal class ArrayPlus
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            //case1
            //int[,] case1_1 = { { 1, 2 }, { 2, 3 } };
            //int[,] case1_2 = { { 3, 4 }, { 5, 6 } };
            //case2
            int[,] case1_1 = { { 1 }, { 2 } };
            int[,] case1_2 = { { 3 }, { 4 } };
            int[,] result = solution.solution(case1_1, case1_2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int[,] solution(int[,] arr1, int[,] arr2)
        {
            int[,] answer = new int[,] { { } };

            answer = arr1.Clone() as int[,];

            int rows = answer.GetLength(0);
            int cols = answer.GetLength(1);

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    answer[i,j] = arr1[i,j] + arr2[i,j];
                }
            }                        

            return answer;
        }
    }

}