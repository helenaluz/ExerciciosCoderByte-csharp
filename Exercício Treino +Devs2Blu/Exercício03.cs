using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Escreva um programa que separa as casas decimais e inteiras de número, mostre ambos para o usuário
namespace Exercício_Treino__Devs2Blu
{
    internal class Exercício03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número com casas decimais(use , para separar casa decimal do número inteiro");
            string número = Console.ReadLine();

            string[] separado = número.Split(',');

            Console.WriteLine("Número inteiro: " + separado[0]);
            Console.WriteLine("Casa decimal: " + separado[1]);

            Console.ReadKey();
        }
    }
}
