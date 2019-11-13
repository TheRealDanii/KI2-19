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
			*/
			//Abfragen der 2 Werte der ersten Messung:
			Console.WriteLine("Guten Tag.");

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
			uint mittelwert1sys = (Messung1Sys + Messung2Sys) / 2;
			uint mittelwert2dia = (Messung1Dia + Messung2Dia) / 2;

			//Auswertung der Mittelwerte
			if (mittelwert1sys < 120 && mittelwert2dia < 80)
			{
				// Wenn der "mittelwert1sys" kleiner als 120 und "mittelwert2dia" kleiner als 80 ist
				Console.WriteLine("Der Besucher hat einen optimalen Blutdruck. Die Mittelwerte liegen bei: " + mittelwert1sys + " / " + mittelwert2dia);
			}
			else if (mittelwert1sys <= 139 && mittelwert2dia <= 89)
			{
				// Wenn der "mittelwert1sys" kleiner gleich 139 und "mittelwert2dia" kleiner gleich 89 ist
				Console.WriteLine("Der Besucher hat einen normalen Blutdruck. Die Mittelwerte liegen bei: " + mittelwert1sys + " / " + mittelwert2dia);
			}
			else
			{
				//Wenn der Mittelwert der 2 Systolischen Werte größer als 139 oder der Mittelwert der 2 diastolischen Werte über 89 liegen
				Console.WriteLine("Der Besucher hat Bluthochdruck. Die Mittelwerte liegen bei: " + mittelwert1sys + " / " + mittelwert2dia + "\nLassen sie sich beraten.");
			}
			Console.ReadKey();
		}
	}
}
