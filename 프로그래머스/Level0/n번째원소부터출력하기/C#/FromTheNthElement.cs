using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_CodingTest
{
    internal class FromTheNthElement
    {
        /*
        정수 리스트 num_list와 정수 n이 주어질 때, n 번째 원소부터 마지막 원소까지의 모든 원소를 담은 리스트를 return하도록 solution 함수를 완성해주세요. 

        제한사항
        2 ≤ num_list의 길이 ≤ 30
        1 ≤ num_list의 원소 ≤ 9
        1 ≤ n ≤ num_list의 길이
        
        입출력 예
        num_list	n	result
        [2, 1, 6]	3	[6]
        [5, 2, 1, 7, 5]	2	[2, 1, 7, 5]

        입출력 예 #1
        [2, 1, 6]의 세 번째 원소부터 마지막 원소까지의 모든 원소는 [6]입니다.
        
        입출력 예 #2
        [5, 2, 1, 7, 5]의 두 번째 원소부터 마지막 원소까지의 모든 원소는 [2, 1, 7, 5]입니다.

         */
        static void Main(string[] args)
        {
            //string[] numlist = { "2", "1", "6" };
            int[] numlist = { 5, 2, 1, 7, 5 };

            Solution.myPrint(numlist, 3);
        }
    }

    public class Solution
    {
        //내풀이
        public static void myPrint(int[] numlist, int index)
        {
            int[] answer = new int[] { };
            List<int> array = new List<int>();

            for (int i = index; i <= numlist.Length; i++)
            {
                array.Add(numlist[i-1]);
            }

            answer = array.ToArray();
        }

        /*다른사람 풀이1
        * 반복문을 동시에 여러개 증감하면서 사용한다.
        */
        public static void otherUserPrint(int[] numlist, int n)
        {
            int[] answer = new int[numlist.Length - n + 1];

            for (int i = n - 1, j = 0; i < numlist.Length; i++, j++)
            {
                answer[j] = numlist[i];
            }
        }

        /*다른사람 풀이2
         * Linq를 사용한다.
         * 배열에서 사용할 수 있는 Linq는 take, skip이 존재
         * take 주어진 숫자만큼 앞에서 출력을 해준다.
         * skip 주어진 숫자를 건너뛴 나머지 뒤의 값들을 출려해준다.
         */
        public static int[] otherUserPrint2(int[] numlist, int n)
        {
            return numlist.Skip(n - 1).ToArray();
        }
    }
}
