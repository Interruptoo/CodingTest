using System;
using System.Collections.Generic;
using System.Linq;

/*
 문제 설명
1부터 6까지 숫자가 적힌 주사위가 세 개 있습니다. 세 주사위를 굴렸을 때 나온 숫자를 각각 a, b, c라고 했을 때 얻는 점수는 다음과 같습니다.

세 숫자가 모두 다르다면 a + b + c 점을 얻습니다.
세 숫자 중 어느 두 숫자는 같고 나머지 다른 숫자는 다르다면 (a + b + c) × (a2 + b2 + c2 )점을 얻습니다.
세 숫자가 모두 같다면 (a + b + c) × (a2 + b2 + c2 ) × (a3 + b3 + c3 )점을 얻습니다.
세 정수 a, b, c가 매개변수로 주어질 때, 얻는 점수를 return 하는 solution 함수를 작성해 주세요.

제한사항
a, b, c는 1이상 6이하의 정수입니다.
입출력 예
a	b	c	result
2	6	1	9
5	3	3	473
4	4	4	110592
입출력 예 설명
입출력 예 #1

예제 1번에서 세 주사위 숫자가 모두 다르므로 2 + 6 + 1 = 9점을 얻습니다. 따라서 9를 return 합니다.
입출력 예 #2

예제 2번에서 두 주사위 숫자만 같으므로 (5 + 3 + 3) × (5^2 + 3^2 + 3^2 ) = 11 × 43 = 473점을 얻습니다. 따라서 473을 return 합니다.
입출력 예 #3

예제 3번에서 세 주사위 숫자가 모두 같으므로 (4 + 4 + 4) × (4^2 + 4^2 + 4^2 ) × (4^3 + 4^3 + 4^3 ) = 12 × 48 × 192 = 110,592점을 얻습니다. 따라서 110592를 return 합니다.
 */

public class Program
{
    private static void Main(string[] args)
    {
        Solution s = new Solution();

        s.solution(2, 6, 1);    //9
        s.solution(5, 3, 3);    //473
        s.solution(4, 4, 4);    //110592
    }
}

public class Solution
{
    public int solution(int a, int b, int c)
    {
        int answer = 1;
        List<int> list = new List<int>();
        list.Add(a);
        list.Add(b);
        list.Add(c);

        int Cnt = list.Count - list.Distinct().Count() + 1;

        for (int i = 1; i <= Cnt; i++)
        {
            int sum = 0;
            foreach (var item in list)
            {
                sum += powCalc(item, i);
            }

            answer *= sum;
        }

        Console.WriteLine(answer);

        return answer;
    }

    private int powCalc(int x, int y)
    {
        return (int)Math.Pow(x, y);
    }

}