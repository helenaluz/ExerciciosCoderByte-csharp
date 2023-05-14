using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ler um vetor de 10 elementos inteiros e positivos. Criar um segundo vetor da
//seguinte forma: os elementos de índice par receberão os respectivos elementos
//divididos por 2; os elementos de índice ímpar receberão os respectivos
//elementos multiplicados por 3. Imprima os dois vetores.
namespace Exercícios_Vetor_c___Devs2Blu
{
    internal class Exercício03
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            
            foreach(int i in nums) { Console.WriteLine("Insira o valor " + (i + 1) + ":"); nums[i] = int.Parse(Console.ReadLine()); }

            foreach (int i in nums)
            {
                if (nums[i] % 2 != 0) nums[i] = (nums[i] * 3); else { nums[i] /= 2; }
            }

            foreach (int i in nums) { Console.Write(nums[i]+" "); }
            Console.ReadKey();
        }
    }
}
