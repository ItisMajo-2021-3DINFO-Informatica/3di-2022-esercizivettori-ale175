using System;

namespace GiardinaVettori3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dichiarazione variabili
            const int indice = 30;
            int[] valori = new int[indice];
            int valoriCasuali;
            int i = 0;
            int somma = 0;
            float media;

            //Codice del programma
            Console.WriteLine("ESERCIZIO 3");

            for (i = 0; i < indice; i++)
            {
                Random generatore = new Random();
                valoriCasuali = generatore.Next(1, 51);
                valori[i] = valoriCasuali;
                somma = somma + valori[i];
            }

            media = somma / i;
            Console.WriteLine($"La media dei valori è: {media}");
        }
    }
}
