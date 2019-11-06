//Author: Konrad
using System;

namespace Vergleichsoperatoren
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Dieses Programm ist eine Veranschaulichung der Vergleichoperatoren, die wir behandelt haben.\n");

			Console.WriteLine("Bitte gib 2 Zahlen ein, die miteinander verglichen werden sollen:\n");
			int zahl1 = Convert.ToInt32(Console.ReadLine());
			int zahl2 = Convert.ToInt32(Console.ReadLine());

			// Wenn gleich
			if (zahl1 == zahl2)
			{
				Console.WriteLine("Zahl1 = Zahl2");
			}
			// Wenn nicht gleich
			else if (zahl1 != zahl2)
			{
				Console.WriteLine("Zahl1 ist nicht gleich Zahl2");
			}
			// Wenn kleiner gleich
			else if (zahl1 <= zahl2)
			{
				Console.WriteLine("Zahl1 ist größer oder gleich wie Zahl2");
			}
			// Wenn größer gleich
			else if (zahl1 >= zahl2)
			{
				Console.WriteLine("Zahl1 ist kleiner oder gleich wie Zahl2");
			}
			// Wenn größer
			else if (zahl1 > zahl2)
			{
				Console.WriteLine("Zahl1 ist großer als Zahl2");
			}
			// Wenn kleiner
			else if (zahl1 < zahl2)
			{
				Console.WriteLine("Zahl1 ist kleiner als Zahl2");
			}
			// Wenn nichts von dem oberen (hier nicht möglich)
			else
			{
				Environment.Exit(0);
			}
		}
	}
}
