using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Have the function MostFreeTime(strArr) read the strArr parameter being passed which will represent a full day and
 * will be filled with events that span from time X to time Y in the day. The format of each event will be
 * hh:mmAM/PM-hh:mmAM/PM. For example, strArr may be ["10:00AM-12:30PM","02:00PM-02:45PM","09:10AM-09:50AM"].
 * Your program will have to output the longest amount of free time available between the start of your first event
 * and the end of your last event in the format: hh:mm. The start event should be the earliest event in the day and
 * the latest event should be the latest event in the day. The output for the previous input would therefore be 01:30
 * (with the earliest event in the day starting at 09:10AM and the latest event ending at 02:45PM).
 * The input will contain at least 3 events and the events may be out of order.*/
namespace Treino_prova__Devs2Blu
{
    internal class MostFreeTime
    {
        static void Main(string[] args)
        {
            string[] strArr = new string[3];
            for(int i = 0; i < strArr.Length; i++) { Console.WriteLine("Insira tempo: "); strArr[i] = Console.ReadLine(); }
            Array.Sort(strArr);

            TimeSpan[] TEMPOS = new  TimeSpan[3];
            for(int i = 0 ; i < strArr.Length ; i++)
            {
                string str = strArr[i];
                string[] tempos = str.Split('-');
                string um = tempos[0];
                string dois = tempos[1];
                TimeSpan tempo2 = DateTime.Parse(dois).TimeOfDay;
                TimeSpan tempo1 = DateTime.Parse(um).TimeOfDay;

                if(tempo2 < tempo1)  tempo2 = tempo2.Add(new TimeSpan(24,0,0));
                TimeSpan totalTempo = tempo2 - tempo1;
                TimeSpan output = totalTempo;
                TEMPOS[i] = output;
            }

            Array.Sort(TEMPOS);
            TimeSpan maiorTempo  = TEMPOS[2];
            string reuslt = $"{ maiorTempo.Hours:00};{maiorTempo.Minutes:00}";
            Console.WriteLine(reuslt);
            Console.ReadKey();
        }
    }
}
