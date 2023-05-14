using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio de cálculo de juros compostos: Escreva um programa que calcule o valor de um investimento com juros compostos, dada a taxa de juros e o número de anos.
namespace Exercício_Treino__Devs2Blu
{
    internal class Exercício04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor: ");
            double capital = double.Parse(Console.ReadLine());
            Console.WriteLine("Taxa de juros: (em %)");
            double taxa = (double.Parse(Console.ReadLine()))/100;
            Console.WriteLine("Número de anos: ");
            int tempo = int.Parse(Console.ReadLine());

            double montante = capital * (Math.Pow((1 + taxa), tempo));
            double juros = montante - capital;
            double valorFinal = juros + capital;
            Console.WriteLine("Juros : "+juros.ToString("C"));
            Console.WriteLine("Fim do investimento: " + valorFinal.ToString("C")) ;
            Console.ReadKey();
        }
    }
}
