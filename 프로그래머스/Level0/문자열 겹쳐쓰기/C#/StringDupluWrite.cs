using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_CodingTest
{
    /*
     문제 설명
    문자열 my_string, overwrite_string과 정수 s가 주어집니다. 문자열 my_string의 인덱스 s부터 overwrite_string의 길이만큼을 문자열 overwrite_string으로 바꾼 문자열을 return 하는 solution 함수를 작성해 주세요.

    제한사항
    my_string와 overwrite_string은 숫자와 알파벳으로 이루어져 있습니다.
    1 ≤ overwrite_string의 길이 ≤ my_string의 길이 ≤ 1,000
    0 ≤ s ≤ my_string의 길이 - overwrite_string의 길이
    입출력 예
    my_string	overwrite_string	s	result
    "He11oWor1d"	"lloWorl"	2	"HelloWorld"
    "Program29b8UYP"	"merS123"	7	"ProgrammerS123"
    입출력 예 설명
    입출력 예 #1

    예제 1번의 my_string에서 인덱스 2부터 overwrite_string의 길이만큼에 해당하는 부분은 "11oWor1"이고 이를 "lloWorl"로 바꾼 "HelloWorld"를 return 합니다.
    입출력 예 #2

    예제 2번의 my_string에서 인덱스 7부터 overwrite_string의 길이만큼에 해당하는 부분은 "29b8UYP"이고 이를 "merS123"로 바꾼 "ProgrammerS123"를 return 합니다.
     */
    internal class StringDupluWrite
    {
        private static void Main(string[] args)
        {
            Solution solution = new Solution();

            string my_string;
            string overwrite_string;
            int s;

            #region case1
            my_string = "He11oWor1d";
            overwrite_string = "lloWorl";
            s = 2;
            Console.WriteLine(solution.solution(my_string, overwrite_string, s));
            #endregion case1

            #region case2
            my_string = "Program29b8UYP";
            overwrite_string = "merS123";
            s = 7;
            Console.WriteLine(solution.solution(my_string, overwrite_string, s));
            #endregion case2
        }
    }


    public class Solution
    {
        public string solution(string my_string, string overwrite_string, int s)
        {
            string answer = "";

            List<char> my_array = new List<char>();
            my_array = my_string.ToList();

            for(int i = 0, j = s; i < overwrite_string.Length; i++, j++)
            {
                my_array[j] = overwrite_string[i];
            }

            answer = string.Join("", my_array);

            return answer;
        }

        public string otherUserSolution(string my_string, string overwrite_string, int s)
        {
            string answer = "";
            answer = my_string.Remove(s, overwrite_string.Length);
            answer = answer.Insert(s, overwrite_string);
            return answer;
        }

        public string otherUserSolution2(string my_string, string overwrite_string, int s)
        {
            return my_string.Substring(0, s) + overwrite_string + my_string.Substring(s + overwrite_string.Length);
        }
    }
}
