using System;
using System.Collections.Generic;
//Escreva um programa que simule um jogo de cartas, onde as cartas são distribuídas aleatoriamente entre os jogadores. O programa deve ordenar as cartas de cada jogador em ordem
//crescente e imprimir a mão de cada jogador.
namespace Exercício_Treino__Devs2Blu
{
    internal class ExercícioUnico
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos jogadores?");
            int numJog = int.Parse(Console.ReadLine());
            List<string> cartas = new List<string>();
            string[] cartasArr = { "CA","C1","C2","C3","C4","C5","C6","C7","C8","C9","C10","CV","CD","CR","EA","E1","E2","E3","E4","E5","E6","E7","E8","E9","E10","EV","ED","ER",
                                "OA","O1","O2","O3","O4","O5","O6","O7","O8","O9","O10","OV","OD","OR","PA","P1","P2","P3","P4","P5","P6","P7","P8","P9","P10","PV","PD","PR"};

            for (int i = 0; i < cartasArr.Length; i++)
            {
                cartas.Add(cartasArr[i]);
            }
            //Metodo de fisher para embaralhar
            Fisher(cartas);

            //lista de vetor pra cada jogador
            int numeroCartas = cartas.Count / numJog;
            List<string>[] maosJogadores = new List<string>[numJog];

            for (int i = numJog - 1; i >= 0; i--)
            {
                maosJogadores[i] = new List<string>();
                //para cada lista de jogador se adiciona o conjunto de número de cartas
                for (int j = i * numeroCartas; j < (i + 1) * numeroCartas; j++)
                { maosJogadores[i].Add(cartas[j]); cartas.Remove(cartas[j]); }
            }

            // distribui o resto das cartas (divisão não inteira na linha 25)
            int cartasRestantes = cartas.Count % numJog;

            if (cartasRestantes < 0)
            {
                for (int i = 0; i < cartasRestantes; i++)
                { maosJogadores[i].Add(cartas[i]); cartas.Remove(cartas[i]); }
            }

            // Ordenando as cartas de cada jogador
            for (int i = 0; i < numJog; i++)
            {
                maosJogadores[i].Sort();
                Console.WriteLine($"Mão do jogador {i + 1}: {string.Join(", ", maosJogadores[i])}");
            }
            Console.ReadKey();
        }



        public static void Fisher(List<string> n)
        {
            Random random = new Random();
            int num = n.Count;

            while (num > 1)
            {
                num--;
                int k = random.Next(num + 1);
                string temp = n[k];
                n[k] = n[num];
                n[num] = temp;
            }
        }
    }
}
