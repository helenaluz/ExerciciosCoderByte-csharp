using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Have the function PalindromeTwo(str) take the str parameter being passed and return the string true if the parameter
 * is a palindrome, (the string is the same forward as it is backward) otherwise return the string false.
 * The parameter entered may have punctuation and symbols but they should not affect whether the string is in fact
 * a palindrome. For example: "Anne, I vote more cars race Rome-to-Vienna" should return true.*/
namespace Treino_prova__Devs2Blu
{
    internal class PalindromeTwo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a string:");
            string str = Console.ReadLine();

            str.Trim();
            char[] chars = str.ToCharArray();
            List<char> original = new List<char>();
            List<char> reverso = new List<char>();
            for (int i = 0; i < chars.Length; i++)
            {
                char c = Char.ToLower(chars[i]);
                if (Char.IsLetter(c))
                {
                    original.Add(c); reverso.Add(c);
                }

            }
            reverso.Reverse();
            int count = 0;
            for(int i =0; i < original.Count; i++) if (original[i] != reverso[i]) count++;

            Console.WriteLine(count == 0 ? "É palíndromo" : "Não é palíndromo");
            Console.ReadKey();

        }
    }
}
