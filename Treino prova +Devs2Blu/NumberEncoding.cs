using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* * Have the function NumberEncoding(str) take the str parameter and encode the message according to the following rule:
 * encode every letter into its corresponding numbered position in the alphabet.
 * Symbols and spaces will also be used in the input.
 * For example: if str is "af5c a#!" then your program should return 1653 1#!.*/
namespace Treino_prova__Devs2Blu
{
    internal class NumberEncoding
    {
        static void Main(string[] args)
        {
            char[] letrasMinusculas = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Insira a string: ");
            string str = Console.ReadLine();

            char[] chars = str.ToCharArray();
            ArrayList nums = new ArrayList();
            
            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];
                if (Char.IsLetter(c))
                {
                    c = Char.ToLower(c);
                    for (int j = 0; j < letrasMinusculas.Length; j++)
                    {
                        if (c == letrasMinusculas[j])
                        {
                            int index = j + 1;
                            string indexStr =index.ToString();
                            nums.Add(indexStr);
                            break;
                        }
                    }
                }
                else
                {
                    nums.Add(c);
                }
            }

            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i]);
            }

            Console.ReadKey();
        }
    }
}
