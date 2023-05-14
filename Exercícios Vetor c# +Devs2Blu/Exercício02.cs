using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ler um vetor de 10 elementos. Crie um segundo vetor, com todos os
//elementos na ordem inversa, ou seja, o último elemento passará a ser o
//primeiro, o penúltimo será o segundo e assim por diante. Imprima os dois
//vetores.

namespace Exercícios_Vetor_c___Devs2Blu
{
    internal class Exercício02
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            int[] nums2 = new int[10];
            int j = 10;

            for(int i =0; i < 10; i++)
            {Console.WriteLine("Insira o valor "+(i+1)+":");
                j--;
                nums[i] = int.Parse(Console.ReadLine());
                nums2[i] = nums[i];
                }

          
            Console.WriteLine(" \nLista ordem original:   ");

            for (int i = 0; i < nums.Length; i++)
            {Console.Write(nums[i] +"  ");}
            Array.Reverse(nums);

            Console.WriteLine(" \nLista ordem reversa:");
            for (int i = 0; i < nums.Length; i++)
            {Console.Write(nums[i]+"  ");}


            Console.ReadKey();
        }
    }
}
