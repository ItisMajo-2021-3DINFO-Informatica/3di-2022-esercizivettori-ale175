using System;

namespace GiardinaVettori2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dichiarazione variabili
            const int indice = 100;
            int[] valori = new int[indice];
            int valoreCasuale;
            int i = 0;

            //Codice del programma
            Console.WriteLine("ESERCIZIO VETTORI 2");

            for ( i = 0; i < indice; i++)
            {
                Random generatore = new Random();
                valoreCasuale = generatore.Next(1, 101);
                valori[i] = valoreCasuale;

                if (valori[i] > 50)
                {
                    Console.WriteLine(valori[i]);
                }
            }

        }
    }
}
