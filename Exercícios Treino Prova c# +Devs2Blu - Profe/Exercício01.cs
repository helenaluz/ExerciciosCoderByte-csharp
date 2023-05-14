using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/*Desafio de palíndromo: Escreva um programa que verifique se uma palavra é um palíndromo. Um palíndromo é uma palavra que é lida da mesma forma de trás para frente e de frente para 
 * trás. Exemplos de palíndromos são "arara", "radar" e "reviver".*/
namespace Exercício_Treino__Devs2Blu
{
    internal class Exercício01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira uma palavra: ");
            string palavra = Console.ReadLine();

            char[] letras = palavra.ToCharArray();
            char[] reverse = palavra.ToCharArray();
            int count = 0;
            Array.Reverse(reverse);
            string palavraReversa = new string(reverse);
            for(int i =0; i < letras.Length; i++)
            {
                if (reverse[i] == letras[i]) count++;
            }
            if (count == letras.Length) Console.WriteLine("Essa palavra é um palíndromo, "+palavra+ " fica "+palavraReversa);
            else Console.WriteLine("Essa palavra não é um palíndromo, " + palavra + " fica " + palavraReversa);

            Console.ReadKey();
        }
    }
}
