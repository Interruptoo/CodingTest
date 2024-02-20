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
     영어 알파벳으로 이루어진 문자열 str이 주어집니다. 각 알파벳을 대문자는 소문자로 소문자는 대문자로 변환해서 출력하는 코드를 작성해 보세요.

    제한 조건
    1 ≤ str의 길이 ≤ 20
    str은 알파벳으로 이루어진 문자열입니다.

    입출력 예
    입력 #1
    aBcDeFg

    출력 #1
    AbCdEfG
     */
    internal class StringToUpperToLower
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            //Console.WriteLine(s.Solving1("aBcDeFg"));
            s.Solving2("aBcDeFg");
        }
    }

    public class Solution
    {
        /*내가 작성한 풀이*/
        public String Solving1(string inObj)
        {
            string result = "";
            for(int i = 0; i < inObj.Length; i++)
            {
                //ASCII코드 97~ 122까지 알파벳 소문자
                if (Convert.ToInt16(inObj[i]) > 90)
                {
                    result += inObj[i].ToString().ToUpper();
                }
                //ASCII코드 65 ~ 90까지 알파벳 대문자
                else if (64 < Convert.ToInt16(inObj[i]) && Convert.ToInt16(inObj[i]) < 91)
                {
                    result += inObj[i].ToString().ToLower();
                }
            }

            return result;
        }

        /*다른사람 풀이
          좀더 간략하게 원하는 답을 도출
         */
        public void Solving2(string inObj)
        {
            
            foreach(char c in inObj)
            {
                if (char.IsUpper(c))
                {
                    Console.Write(char.ToLower(c));
                }
                else
                {
                    Console.Write(char.ToUpper(c));
                }
            }
        }
    }
}
