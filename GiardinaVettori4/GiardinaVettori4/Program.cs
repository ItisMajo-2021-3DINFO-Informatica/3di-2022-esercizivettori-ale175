using System;

namespace GiardinaVettori4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dichiarazione variabili
            const int indice = 100;
            int[] valori = new int[indice];
            int i = 0;
            int valoreCasuale;
            int valoreGrande = 999;
            int valorePiccolo = 3001;

            //Codice del programma
            Console.WriteLine("ESERCIZIO 4");

            for (i = 0; i < indice; i++)
            {
                Random generatore = new Random();
                valoreCasuale = generatore.Next(1000, 3001);
                valori[i] = valoreCasuale;

                if (valori[i] < valorePiccolo)
                {
                    valorePiccolo = valori[i];
                }
                else if (valori[i] > valoreGrande)
                {
                    valoreGrande = valori[i];
                }
            }

            Console.WriteLine($"Il valore più grande è: {valoreGrande}, ed il valore più piccolo è: {valorePiccolo}");
        }
    }
}
