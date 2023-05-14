using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//Desafio de sequência de Collatz: Escreva um programa que calcule a sequência de Collatz para um número dado pelo usuário. A sequência de Collatz é gerada a partir de um número
//inteiro positivo, seguindo as seguintes regras: se o número for par, divida por 2; se o número for ímpar, multiplique por 3 e some 1. Repita o processo até chegar ao número 1.
namespace Exercício_Treino__Devs2Blu
{
    internal class Exercício07
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            int num = int.Parse(Console.ReadLine());
            
            if(num <=0) Console.WriteLine("Inválido!");
            else
            {
                List<int> Collatz = new List<int>();

                while (num >1)
                {
                    Collatz.Add(num);
                    if (num % 2 == 0) num = num / 2;
                    else { num = (num * 3) + 1; }
                }

                Collatz.Add(1);
                for (int i = 0; i < Collatz.Count; i++)
                {
                    Console.Write(Collatz[i] + "  ");
                }
                
            }
            Console.ReadKey();
        }
    }
}
