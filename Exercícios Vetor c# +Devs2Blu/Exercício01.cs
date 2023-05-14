using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Faça um programa que lê 10 números inteiros do teclado e armazene em um vetor.Ao final imprima o vetor armazenado nos dois sentidos.

namespace Exercícios_Vetor_c___Devs2Blu
{
    internal class Exercício01
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            
            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Insira o valor "+(i+1)+":");
                nums[i] = int.Parse(Console.ReadLine());}
            for(int i = 0; i < nums.Length ; i++)
            {
                Console.WriteLine(nums[i]);}
            for(int i =0; i < nums.Length; i++)
            {
                Console.Write(nums[i]+"  ");
            }
        }
    }
}
