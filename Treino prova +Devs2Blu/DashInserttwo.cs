using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Have the function DashInsertII(str) insert dashes('-') between each two odd numbers and insert asterisks ('*')
 *between each two even numbers in str. For example: if str is 4546793 the output should be 454*67-9-3.
 * Don't count zero as an odd or even number.*/
namespace Treino_prova__Devs2Blu
{
    internal class DashInserttwo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a str: ");
            string str = Console.ReadLine();

            char[] numbersArr = str.ToCharArray();
            List<char> numbers = new List<char>(numbersArr);

            for (int i = numbers.Count - 1; i >= 1; i--)
            {
                if (numbers[i] % 2 == 0 && numbers[i - 1] % 2 == 0 && numbers[i] != '0' && numbers[i - 1] != '0')
                {
                    numbers.Insert(i, '*');
                }
                if (numbers[i] % 2 != 0 && numbers[i - 1] % 2 != 0 && numbers[i] != '0' && numbers[i - 1] != '0')
                {
                    numbers.Insert(i, '-');
                }
            }
            string strFinal = new string(numbers.ToArray());
            strFinal = strFinal.Trim();
            Console.WriteLine(strFinal);
            Console.ReadKey();
        }
    }
}
