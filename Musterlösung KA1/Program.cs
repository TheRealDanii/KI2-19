//Author: Konrad
//Uploadzeit: 12:30 Uhr

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klausur1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Begrüßung
             *Erste Messung eingabe
             * zweite Messung eingabe
             * berechnung des mittelwerts aus den 2 systolischen
             * berechnung des mittelwerts aus den 2 diastolischen
             * Vergleichen der Mittelwerte ob optimalen (ausgeben), wenn nicht normalen (ausgeben), wenn nicht: Bluthochdruck (ausgeben)
             * Ausgabe
             * -----------------
             * Bonus:
             * Weitere Besucher?
             * Ja -> nach oben
             * Nein -> Schönen Tag noch
             * Nichts -> Schließen
            */
            //Abfragen der 2 Werte der ersten Messung:
            Console.WriteLine("Guten Tag.");
        a:
            Console.WriteLine("Bitte geben sie nacheinander den Systolischen und danach den Diastolischen Wert ein:");
            uint Messung1Sys = Convert.ToUInt16(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Geben sie nun den Diastolischen Wert der ersten Messung ein:");
            uint Messung1Dia = Convert.ToUInt16(Console.ReadLine());
            Console.Clear();

            //Abfragen der 2 Werte der zweiten Messung
            Console.WriteLine("Geben sie nun den systolischen Wert der zweiten Messung ein:");
            uint Messung2Sys = Convert.ToUInt16(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Geben sie nun den Diastolischen Wert der zweiten Messung ein:");
            uint Messung2Dia = Convert.ToUInt16(Console.ReadLine());
            Console.Clear();

            //Berechnung der 2 Mittelwerte
            uint zwischenwert1 = Messung1Sys + Messung2Sys;
            uint mittelwert1sys = zwischenwert1 / 2;

            uint zwischenwert2 = Messung1Dia + Messung2Dia;
            uint mittelwert2dia = zwischenwert2 / 2;

            //Auswertung der Mittelwerte
            if (mittelwert1sys < 120 && mittelwert2dia < 80)
            {
                //Wenn der Mittelwert der 2 Systolischen Werte unter 120 liegen und der Mittelwert der 2 Diastolischen Werte unter 80 liegen
                Console.WriteLine("Der Besucher hat einen optimalen Blutdruck. Die Mittelwerte liegen bei: " + mittelwert1sys + " / " + mittelwert2dia);
                Console.ReadLine();
            }

            else if (mittelwert1sys >= 120 & mittelwert1sys <= 139 || mittelwert2dia >= 80 & mittelwert2dia <= 89)
            {
                //Wenn der Mittelwert der 2 Systolischen Werte gleich/über 120 liegen und kleiner als 140 sind, der Mittelwert der 2 Diastolischen Werte über 79 liegen und unter 90
                Console.WriteLine("Der Besucher hat einen normalen Blutdruck. Die Mittelwerte liegen bei: " + mittelwert1sys + " / " + mittelwert2dia);
                Console.ReadLine();
            }

            else if (mittelwert1sys >= 140 || mittelwert2dia >= 90)
            {
                //Wenn der Mittelwert der 2 Systolischen Werte größer als 139 und der MIttelwert der 2 diastolischen Werte über 89 liegen
                Console.WriteLine("Der Besucher hat Bluthochdruck. Die Mittelwerte liegen bei: " + mittelwert1sys + " / " + mittelwert2dia + "\nLassen sie sich beraten.");
                Console.ReadLine();
            }
            else
            {
                //Debug-Info (Normal nicht möglich)
                Console.WriteLine("Ausgabe Fehlerhaft");
                Console.ReadLine();
            }

            Console.WriteLine("Möchten sie einen neuen Besucher euintragen? (ja/nein)");
            string antwort0 = Console.ReadLine();
            if (antwort0 == "ja")
            {
                Console.Clear();
                goto a;
            }
            else if (antwort0 == "nein")
            {
                Console.WriteLine("Schönen Tag noch!");
                Console.ReadLine();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}