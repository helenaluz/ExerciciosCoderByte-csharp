using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Have the function Consecutive(arr) take the array of integers stored in arr and return the minimum number of
 * integers needed to make the contents of arr consecutive from the lowest number to the highest number.
 * For example: If arr contains [4, 8, 6] then the output should be 2 because two numbers need to be added to the
 * array (5 and 7) to make it a consecutive array of numbers from 4 to 8.
 * Negative numbers may be entered as parameters and no array will have less than 2 elements.
 *
 * @author Nick Livens
 */
namespace Treino_prova__Devs2Blu
{
    internal class Consecutive
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Informe o número");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            int amount = 0;

            for (int i = (arr.Length-1); i >= 1; i--)
            {
                int index = arr[i] - arr[i - 1];
                amount += Math.Max(0, index - 1);
            }

            Console.WriteLine(amount);
            Console.ReadKey();
    } }
}
