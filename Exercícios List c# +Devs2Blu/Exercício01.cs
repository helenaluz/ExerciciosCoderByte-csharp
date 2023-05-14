using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crie um programa que simule uma caixa registradora. O programa deve receber um número desconhecido de preços de produtos como entrada do usuário, usando o método Add() para
//adicionar cada valor à lista. Quando o usuário digitar 0 como preço, o programa deve calcular o total da compra usando o método Sum() da lista e exibi-lo na tela. Em seguida, o
//programa deve pedir ao usuário que informe o valor em dinheiro que foi fornecido e calcular o troco usando o método Subtract() da classe Decimal. Por fim, o programa deve limpar a
//lista e voltar ao ponto inicial.

namespace Exercícios_List_c___Devs2Blu
{
    internal class Exercício01
    {

        static void Main(string[] args)
        {
            List<decimal> caixa = new List<decimal>();

            int validação = 0;

            while (validação ==0)
            {
                Console.WriteLine("Bem vindo á Caixa Registradora do +Devs2Blu! ");

                validação = 1;
                Console.WriteLine("Para parar de receber valores de preço digite 0");
                while (true){
                    Console.Write("Preço: R$ ");
                    decimal preco = decimal.Parse(Console.ReadLine());
                    caixa.Add(preco);
                    if (preco == 0) { break; }}

                decimal total = caixa.Sum();
                Console.WriteLine("TOTAL = " + total.ToString("C"));
                Console.Write("Dinheiro fornecido: R$");
                decimal valor = decimal.Parse(Console.ReadLine());
                decimal troco = Decimal.Subtract(valor, total);
                Console.WriteLine("TROCO: " + troco.ToString("C"));
                caixa.RemoveRange(0,caixa.Count);

                Console.WriteLine("Para sair digite 1");
                int vali = int.Parse(Console.ReadLine());
                if(vali != 1) { validação = 0; }
            }
           
            Console.ReadKey();
        }
    }
}
