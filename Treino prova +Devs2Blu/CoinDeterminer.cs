using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
/*Using the Java language, have the function CoinDeterminer(num) take the input, which will be an integer ranging
 * from 1 to 250, and return an integer output that will specify the least number of coins, that when added,
 * equal the input integer. Coins are based on a system as follows: there are coins representing the integers
 * 1, 5, 7, 9, and 11. So for example: if num is 16, then the output should be 2 because you can achieve the
 * number 16 with the coins 9 and 7. If num is 25, then the output should be 3 because you can achieve 25 with
 * either 11, 9, and 5 coins or with 9, 9, and 7 coins.*/
namespace Treino_prova__Devs2Blu
{
    internal class CoinDeterminer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor: ");
            int valor = int.Parse(Console.ReadLine());

            int onze = valor / 11;
            valor %= 11;
            Console.WriteLine(valor);
            int nove = valor / 9;
            valor %= 9;
            int sete = valor / 7;
            valor %= 7;
            int cinco = valor / 5;
            int um = valor % 5;
            
            int totalMoedas = onze+ nove+sete+ cinco+ um;

            Console.WriteLine("Total = "+ totalMoedas);
            Console.WriteLine("11: "+ onze);
            Console.WriteLine("9: "+nove);
            Console.WriteLine("7: "+sete);
            Console.WriteLine("5: "+ cinco);
            Console.WriteLine("1: "+um);
            Console.ReadKey ();
        }
    }
}
