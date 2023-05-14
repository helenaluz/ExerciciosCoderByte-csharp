using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Have the function FormattedDivision(num1,num2) take both parameters being passed, divide num1 by num2, and return
 * the result as a string with properly formatted commas and 4 significant digits after the decimal place.
 * For example: if num1 is 123456789 and num2 is 10000 the output should be "12,345.6789".
 * The output must contain a number in the one's place even if it is a zero.*/
namespace Treino_prova__Devs2Blu
{
    internal class FormattedDivion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero 1:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Número 2: ");
            double num2 = double.Parse(Console.ReadLine());

            double division = num1 / num2;

            string result = division.ToString("000,000,000.0000");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
