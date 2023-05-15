using System;
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
        {   Console.WriteLine("Insira String:");
            string str = Console.ReadLine();

            string[] times = str.Split('-');
            string time1 = times[0];
            string time2 = times[1];
            TimeSpan ts1 = DateTime.Parse(time1).TimeOfDay;
            TimeSpan ts2 = DateTime.Parse(time2).TimeOfDay;
            if (ts2 < ts1) ts2 = ts2.Add(new TimeSpan(24, 0, 0));
            int retorno = (int)(ts2 - ts1).TotalMinutes;
            Console.WriteLine(retorno);

            Console.ReadKey();
        }

    }
}
