using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/**
 * Have the function Division(num1,num2) take both parameters being passed and return the Greatest Common Factor.
 * That is, return the greatest number that evenly goes into both numbers with no remainder.
 * For example: 12 and 16 both are divisible by 1, 2, and 4 so the output should be 4.
 * The range for both parameters will be from 1 to 10^3.
 */
namespace Treino_prova__Devs2Blu
{
    internal class Divisão
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Número 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int a = Math.Min(num1, num2);
            int b = Math.Max(num1, num2);

            int mdc = division(b, a);

            Console.WriteLine("O MDC é: " + mdc);
            Console.ReadKey();
        }
        static int division(int max, int min)
        {
            int r = 0;
            while(min != 0)
            {
                r = max % min;
                max = min;
                min = r;

            }
            return max;
        }
    }
}
