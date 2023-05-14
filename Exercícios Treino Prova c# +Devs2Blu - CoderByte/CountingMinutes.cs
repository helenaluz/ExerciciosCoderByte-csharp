using System;
using System.Linq;
/*Have the function CountingMinutes(str) take the str parameter being passed which will be two times (each properly
 * formatted with a colon and am or pm) separated by a hyphen and return the total number of minutes between the two
 * times. The time will be in a 12 hour clock format.
 * For example: if str is 9:00am - 10:00am then the output should be 60.
 * If str is 1:00pm - 11:00am the output should be 1320.*/

namespace Treino_prova__Devs2Blu
{
    internal class CountingMinutes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Horario:");
            string hora = Console.ReadLine();
            string[] horas = hora.Split('-');
            string[] hora1 = horas[0].Split(':');
            string[] hora2 = horas[0].Split(':');
            char[] h1 = hora1.Cast<char>().ToArray();
            char[] h2 = hora2.Cast<char>().ToArray();
            int H1 = 0;
            int H2 = 0;
            if (h1.Length == 5)
            {
                if (h1[3] == 'p')
                {
                    H1 = h1[0] + 12;
                }
                if (h1[3] == 'a') H1 = h1[0];
            }
            else if (h1.Length == 6)
            {
                if (h1[4] == 'p')
                {
                    string x = (h1[0].ToString() + h1[1].ToString());
                    H2 = 12 + (int.Parse(x)); ;
                }
                if (h1[4] == 'a')
                {
                    string x = (h1[0].ToString() + h1[1].ToString());
                    H1 = int.Parse(x);
                }

            }
            if (h2.Length == 5)
            {
                if (h2[3] == 'p')
                {
                    H2 = h2[0] + 12;
                }
                if (h2[3] == 'a')
                {
                    H2 = h2[0];
                }
            }
            else if (h2.Length == 6)
            {
                if (h2[4] == 'p')
                {
                    string x = (h1[0].ToString() + h1[1].ToString());
                    H2 = 12 + (int.Parse(x));
                }
                if (h2[4] == 'a')
                {
                    string x = (h1[0].ToString() + h1[1].ToString());
                    H2 = int.Parse(x);
                }

            }




        }
    }
}
