using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Have the function BracketMatcher(str) take the str parameter being passed and return 1 if the brackets are correctly
matched and each one is accounted for. Otherwise return 0. For example: if str is "(hello (world))", then the output
should be 1, but if str is "((hello (world))" the the output should be 0 because the brackets do not correctly
match up. Only "(" and ")" will be used as brackets. If str contains no brackets return 1.
 */
namespace Treino_prova__Devs2Blu
{
    internal class BracketMatcher
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a string");
            string frase = Console.ReadLine();

            frase = frase.Trim();
            char[] check = frase.ToCharArray();
            List<char> checkList = new List<char>(check);

            for (int c = 0; c < checkList.Count; c++)
            { if (checkList[c] != '(' && checkList[c] != ')') checkList.RemoveAt(c); }

            checkList.Sort();
            int count1 = 0;
            int count2 = 0;

            foreach (char c in checkList)
            {
                if (c == '(')
                {
                    count1++;
                    if (c == ')') count2++;
                }

                if (count1 == count2) { Console.WriteLine("True"); }
                else { Console.WriteLine("False"); }
                Console.ReadKey();
            }
        }
    }
}
