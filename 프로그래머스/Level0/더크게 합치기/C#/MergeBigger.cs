using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Programers_CodingTest
{
    /*
     연산 ⊕는 두 정수에 대한 연산으로 두 정수를 붙여서 쓴 값을 반환합니다. 예를 들면 다음과 같습니다.

    12 ⊕ 3 = 123
    3 ⊕ 12 = 312
    양의 정수 a와 b가 주어졌을 때, a ⊕ b와 b ⊕ a 중 더 큰 값을 return 하는 solution 함수를 완성해 주세요.

    단, a ⊕ b와 b ⊕ a가 같다면 a ⊕ b를 return 합니다.

    제한사항
    1 ≤ a, b < 10,000
    입출력 예
    a	b	result
    9	91	991
    89	8	898

    입출력 예 설명
    입출력 예 #1

    a ⊕ b = 991 이고, b ⊕ a = 919 입니다. 둘 중 더 큰 값은 991 이므로 991을 return 합니다.
    
    입출력 예 #2

    a ⊕ b = 898 이고, b ⊕ a = 889 입니다. 둘 중 더 큰 값은 898 이므로 898을 return 합니다.
     
     */

    internal class MergeBigger
    {
        private static void Main(string[] args)
        {
            Solution s = new Solution();
            s.solution(9, 91);
        }
    }

    public class Solution
    {
        public int solution(int a, int b)
        {
            int answer = 0;
            int item1 = Convert.ToInt32((a.ToString() + b.ToString()));
            int item2 = Convert.ToInt32((b.ToString() + a.ToString()));

            answer = item1 >= item2 ? item1 : item2;

            return answer;
        }

        //다른 유저 풀이
        //문자열로 Casting 해서 Concat 까지는 동일하다. 다만 나는 Tostring()으로 Casting 했는데 "" 로 감싸면 자동 캐스팅을 이용한게 참신함
        //concat한 값을 나는 삼항식을 이용해 간단하게 작성했다면 밑에 유저는 Math.Max 내장함수를 사용했는데 좀 더 깔끔하다.
        public int solution2(int a, int b)
        {
            int aNum = Int32.Parse($"{a}{b}");
            int bNum = Int32.Parse($"{b}{a}");
            return Math.Max(aNum, bNum);
        }
    }
}
