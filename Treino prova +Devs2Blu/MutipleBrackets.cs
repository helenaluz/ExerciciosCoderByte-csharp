using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Have the function MultipleBrackets(str) take the str parameter being passed and return 1 #ofBrackets if the brackets
 * are correctly matched and each one is accounted for. Otherwise return 0. For example: if str is "(hello [world])(!)",
 *then the output should be 1 3 because all the brackets are matched and there are 3 pairs of brackets,
 * but if str is "((hello [world])" the the output should be 0 because the brackets do not correctly match up.
 * Only "(", ")", "[", and "]" will be used as brackets. If str contains no brackets return 1.*/
namespace Treino_prova__Devs2Blu
{
    internal class MutipleBrackets
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a string: ");
            string str = Console.ReadLine();

            str.Trim();
            char[] chars = str.ToCharArray();

            List<char> curveR = new List<char>();
            List<char> curveL = new List<char>();
            List<char> blockR = new List<char>();
            List<char> blockL = new List<char>();

            for(int i = 0; i < chars.Length;i++)
            {
                if (chars[i] == '(') curveR.Add(chars[i]);
                if (chars[i] == ')') curveL.Add(chars[i]);
                if (chars[i]== '[') blockR.Add(chars[i]);
                if (chars[i] == ']') blockL.Add(chars[i]);
            }

            int val = 0;

            if(curveR.Count==0 && curveL.Count==0 && blockL.Count == 0 && blockR.Count == 0) { Console.WriteLine(1); return; }
            else
            {
                if(curveL.Count == curveR.Count)  val++; 
                if(blockR.Count == blockL.Count) val++;
            }

            if(val == 2) Console.WriteLine(1);
            else Console.WriteLine(0);

            Console.ReadKey();
        }
    }
}
