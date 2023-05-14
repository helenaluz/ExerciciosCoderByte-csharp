using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio de validação de CPF: Escreva um programa que valide se um número de CPF é válido ou não.
namespace Exercício_Treino__Devs2Blu
{
    internal class Exercício02
    {
        static void Main(string[] args)
        {
            //Pega a string CPF
            Console.WriteLine("Insira o seu CPF: ");
            string cpf = Console.ReadLine();

            //Arruma a string, pra deixar ela limpa
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            //converção da string para int[]
            char[] cpfArrchar = cpf.ToCharArray(); 
            int[] cpfArr = new int[cpfArrchar.Length];
            for(int i = 0; i < cpfArrchar.Length; i++)
            { cpfArr[i] = int.Parse(cpfArrchar[i].ToString()); }

            //já checa se tem a quantidade de digitos necessários
            if(cpfArr.Length !=11 ) { Console.WriteLine("Inálido!"); return; }
            
            //vetores de validação
            int[] val1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] val2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int digito1 = 0;
            int digito2 = 0;

            //checagem dos 2 últimos digitos
            for(int i =0; i < val1.Length; i++)
            {digito1 += (val1[i] * cpfArr[i]);}
            for(int i=0;i< val2.Length; i++)
            { digito2 += (val2[i] * cpfArr[i]); }

            int resto1 = digito1 % 11;
            int suposto1 = 0;
            if (resto1 < 2) suposto1 = 0;
            else suposto1 = 11 - resto1;

            int resto2 = digito2 % 11;
            int suposto2 = 0;
            if (resto1 < 2) suposto2 = 0;
            else suposto2 = 11 - resto2;

            //ve se está tudo de acordo e faz a validação
            if(suposto1 == cpfArr[9] && suposto2 == cpfArr[10]) Console.WriteLine("CPF válido!");
            else Console.WriteLine("CPF inválido!");

            Console.ReadKey();
        }
    }
}
