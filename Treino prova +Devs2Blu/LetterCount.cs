using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Have the function LetterCount(str) take the str parameter being passed and return the first word with the greatest
 * number of repeated letters. For example: "Today, is the greatest day ever!" should return greatest because it has
 * 2 e's (and 2 t's) and it comes before ever which also has 2 e's.
 * If there are no words with repeating letters return -1. Words will be separated by spaces.
 */
namespace Treino_prova__Devs2Blu
{
    internal class LetterCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a string: ");
            string frase = Console.ReadLine();
            string[] palavra = frase.Split(' ');
            int[] contagem = new int[palavra.Length];
            for (int i = 0; i < palavra.Length; i++)
            {
                char[] letras = palavra[i].ToLower().ToCharArray();
                Array.Sort(letras);
                int count = 0;
                for (int j = 0; j < letras.Length - 1; j++)
                {
                    if (letras[j] == letras[j + 1])
                    {
                        count++;
                        if (count == 1)
                        {
                            contagem[i]++;
                        }
                    }
                }
            } 
            int maxIndex = Array.IndexOf(contagem, contagem.Max());
            if (contagem[maxIndex] == 0) 
            {
                Console.WriteLine("-1");
            }
            else 
            {
                Console.WriteLine(palavra[maxIndex]);
            }
            Console.ReadKey();
        }
    }
}
