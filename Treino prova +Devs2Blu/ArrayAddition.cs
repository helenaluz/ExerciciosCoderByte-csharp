using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
/*Have the function ArrayAdditionI(arr) take the array of numbers stored in arr and return the string true if any
* combination of numbers in the array can be added up to equal the largest number in the array, otherwise return the
* string false. For example: if arr contains[4, 6, 23, 10, 1, 3] the output should return true because
* 4 + 6 + 10 + 3 = 23. The array will not be empty, will not contain all the same elements,
* and may contain negative numbers.*/
namespace Treino_prova__Devs2Blu
{
    internal class ArrayAddition
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];

            for(int i = 0; i < arr.Length;i++)
            {
                Console.WriteLine("Número: ");
                arr[i] = int.Parse(Console.ReadLine());}

            Array.Sort(arr);
            bool val = false;
           int high = arr[3];
           int sum = 0;
            for(int i =0;i<( arr.Length-1);i++) 
            {
                
                sum += arr[i];
                for(int j =i; j < arr.Length-1;j++)
                {
                    sum += arr[j];
                    if(sum == high) val = true;
                    
                }
                for(int k =i; k < arr.Length - 1; k++)
                {
                    if(i!=k)
                    { sum -= arr[k];}
                    if(sum == high) val = true;
                }
               sum = 0;
            }
            Console.WriteLine(val);
            Console.ReadKey();


        }
    }
}
