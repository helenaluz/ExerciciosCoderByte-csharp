using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Escreva um programa que ordene uma lista de números e remova os números repetidos. O programa deve imprimir a lista ordenada e sem repetições.
namespace Exercício_Treino__Devs2Blu
{
    internal class Exercício08
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            List<int> listOficial = new List<int>();
            bool val = true;
            while (val)
            {
                Console.WriteLine("Você esta adicionando números na lista (para sair digite 2000)");
                int num = int.Parse(Console.ReadLine());
                if (num == 2000) break;
                else  list.Add(num);
            }

            foreach (int num in list) { if (!listOficial.Contains(num)) { listOficial.Add(num); } }

            listOficial.Sort();

            Console.WriteLine("\n -*- LISTA -*-");
            for (int i = 0; i < listOficial.Count; i++)
            {
                Console.Write(listOficial[i]+" ");
            }

            Console.ReadKey();

        }
    }
}