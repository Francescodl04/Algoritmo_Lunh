/**
 * @file Program.cs
 * @author Francesco Di Lena, classe 4F
 * @brief Implementazione dell'Algoritmo di Lunh in C#
 * @date 06/05/2022
 * 
**/

using System;

namespace algoritmo_Luhn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel programma. Questo programma serve per verificare la validità di un codice PAN.");
            while (true)
            {
                string PAN_CartaCredito;
                int somma = 0;
                Console.WriteLine($"Inserisci il PAN della carta di credito:");
                PAN_CartaCredito = Console.ReadLine();
                for (int i = PAN_CartaCredito.Length - 1; i >= 0; i--)
                {
                    if (i % 2 == 0)
                    {
                        somma += 2 * int.Parse(Convert.ToString(PAN_CartaCredito[i]));
                    }
                    else
                    {
                        somma += int.Parse(Convert.ToString(PAN_CartaCredito[i]));
                    }
                }
                if (somma % 10 == 0)
                {
                    Console.WriteLine("Quello che hai inserito è un codice PAN valido!");
                }
                else
                {
                    Console.WriteLine("NON hai inserito un codice PAN valido!");
                }
                Console.WriteLine("Vuoi uscire dal programma oppure ripetere l'inserimento? (S per chiudere, qualsiasi altro tasto per continuare)");
                string scelta = Console.ReadLine();
                if (scelta.ToUpper() == "S")
                {
                    break;
                }
            }
        }
    }
}
