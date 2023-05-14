using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crie um programa que permita ao usuário criar uma lista de compras. O usuário pode adicionar novos itens à lista usando o método Add(), remover itens existentes usando o método
//Remove() e exibir a lista completa usando o método foreach. Quando o usuário tiver concluído sua lista, ele deve sair do programa.

namespace Exercícios_List_c___Devs2Blu
{
    internal class Exercício02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você quer criar uma lista de compras? (1- Sim | 0-Não)");
            int resposta = int.Parse(Console.ReadLine());
            while (resposta != 0 && resposta != 1) { Console.WriteLine("Use 1-Sim e 0-Não"); resposta = int.Parse(Console.ReadLine()); }
            if (resposta == 1)
            {
                List<String> Compras = new List<String>();
                Console.WriteLine("Para adicionar itens digite 0\nPara remover itens digite 1\nPara ver sua lista digite 2");
                
                int escolha = int.Parse(Console.ReadLine());

                while (escolha == 0)
                {
                    Console.WriteLine("Você está adicionando itens, para sair dessa aba digite 3\nPara remover itens digite 1\nPara ver sua lista digite 2");
                    Console.Write(" - ");
                    string item = Console.ReadLine();
                    if (item == "1") { escolha = 1; }
                    else if (item == "2") { escolha = 2; }
                    else if (item == "3") { break; }
                    else
                    {
                        if (Compras.Find(compra => compra == item) == item) { Console.WriteLine("Item já cadastrado"); }
                        else Compras.Add(item);
                    }
                    while (escolha == 1)
                    {
                        Console.WriteLine("Você está removendo itens, para sair dessa aba digite 3\nPara adicionar itens digite 0\nPara ver sua lista digite 2");
                        Console.Write(" - ");
                        string remover = Console.ReadLine();
                        if (remover == "0") { escolha = 0; }
                        else if (remover == "2") { escolha = 2; }
                        else if (remover == "3") { break; }

                        else
                        {
                            if (Compras.Find(compra => compra == item) == null) { Compras.Remove(remover); }
                            else Console.WriteLine("Item não registrado"); ;
                        }
                    }
                    if(escolha == 2)
                    {
                        Console.WriteLine("Lista: ");
                        foreach (var compra in Compras) { Console.WriteLine(" - " + compra);  }
                        Console.WriteLine("Você está vendo itens, para sair dessa aba digite 3\nPara adicionar itens digite 0\nPara remover itens digite 1");
                        escolha = int.Parse(Console.ReadLine());
                    }
                        
                }
                
            }Console.ReadKey();
        }
    }
}

