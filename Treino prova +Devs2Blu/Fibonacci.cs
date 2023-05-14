using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Have the function FibonacciChecker(num) return the string yes if the number given is part of the Fibonacci sequence.
 * This sequence is defined by: Fn = Fn - 1 + Fn - 2, which means to find Fn you add the previous two numbers up.
 * The first two numbers are 0 and 1, then comes 1, 2, 3, 5 etc. If num is not in the Fibonacci sequence,
 * return the string no.*/
namespace Treino_prova__Devs2Blu
{

    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o número: ");
            int num = int.Parse(Console.ReadLine());

            int n1 = 0;
            int n2 = 1;

            while (n2 < num)
            {
                int temp = n1;
                n1 = n2; 
                n2 = n2+ temp;
            }
            
            Console.WriteLine(n2 == num ? "É Fibonacci" : "Não é Fibonacci");
            Console.ReadKey();
        }
    }
}
