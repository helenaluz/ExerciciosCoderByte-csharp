using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/*Have the function DistinctList(arr) take the array of numbers stored in arr and determine the total number of
 * duplicate entries. For example if the input is [1, 2, 2, 2, 3] then your program should output 2 because there are
 * two duplicates of one of the elements.*/
namespace Treino_prova__Devs2Blu
{
    internal class DistinctrList
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Número: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            List<int> list = new List<int>(arr);
            List<int> list2 = new List<int>(arr);
            int count = 0;
            for(int i = 0;i< arr.Length; i++)
            {
                int num = arr[i];
                if(list.IndexOf(num) != list.LastIndexOf(num)) 
                {
                    count++;
                    list.RemoveAll(n  => n == num);
                    list.Add(num);                
                }
            }

            int x = list2.Count - list.Count;
            Console.WriteLine(x);

            Console.ReadKey();


        }
    }
}
