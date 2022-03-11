using System;

namespace GiardinaVettori5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dichiarazione variabili
            const int indice = 1000;
            const int perCento = 100;
            double percentuale;
            int[] valori = new int[indice];
            int valoriCasuali;
            double valoriMinori = 0;
            int i = 0;

            //Codice del programma
            Console.WriteLine("ESERCIZIO 5");

            for (i = 0; i < indice; i++)
            {
                Random generatore = new Random();
                valoriCasuali = generatore.Next(1, 251);
                valori[i] = valoriCasuali;

                if (valori[i] < 175)
                {
                    valoriMinori++;
                }
            }

            percentuale = (valoriMinori / i) * perCento;
            Console.WriteLine($"La percentuale dei valori minori di 175 sono: {percentuale}%");
        }
    }
}
