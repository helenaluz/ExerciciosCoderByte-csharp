using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Have the function BinaryConverter(str) return the decimal form of the binary value.
//*For example: if 101 is passed return 5, or if 1000 is passed return 8.

namespace Treino_prova__Devs2Blu
{
    internal class BinaryConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número binário: ");
            string binarioStr = Console.ReadLine();

            int binario = Convert.ToInt32(binarioStr, 2);

            Console.WriteLine($"O número decimal equivalente é {binario}");
            Console.ReadKey();
        }
    }
}
