using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Have the function ArithGeoII(arr) take the array of numbers stored in arr and return the string "Arithmetic"
 * if the sequence follows an arithmetic pattern or return "Geometric" if it follows a geometric pattern.
 * If the sequence doesn't follow either pattern return -1. An arithmetic sequence is one where the difference between
 * each of the numbers is consistent, where as in a geometric sequence, each term after the first is multiplied by
 * some constant or common ratio. Arithmetic example: [2, 4, 6, 8] and Geometric example: [2, 6, 18, 54].
 * Negative numbers may be entered as parameters, 0 will not be entered, and no array will contain all the same element*/
namespace Treino_prova__Devs2Blu
{
    internal class ArithGeoTwo
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Insira um número: ");
                numeros[i] =int.Parse(Console.ReadLine());
            }

            int q = numeros[2] / numeros[1];
            int r = numeros[1] - numeros[0];
            if (numeros[3] == (numeros[0] + 3 * r)) Console.WriteLine("Essa sequencia é uma Progressão Aritimetica"); 
            else if (numeros[3] == numeros[0] * Math.Pow(q, 3))  Console.WriteLine("Essa sequencia é uma Progressão Geométrica"); 
            else Console.WriteLine("Essa sequencia não nem uma P.A nem uma P.G");


            Console.ReadKey();
        }
    }
}
