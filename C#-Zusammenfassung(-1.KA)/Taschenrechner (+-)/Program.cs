using System;

namespace __
{
    class Program
    {
        static void Main(string[] args)
            Console.WriteLine("Möchten sie + oder - rechnen? (+/-)");
            string antwort = Console.ReadLine();
            //Wenn die Antwort "+" ist, wird folgendes ausgeführt:
            if(antwort == "+")
            {
                Console.WriteLine("Geben sie nacheiner 2 Zahlen ein um diese miteinenader zu addieren:\n" +
                    "1. Zahl:");
                decimal zahl1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("2. Zahl:");
                decimal zahl2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("\nDas Ergebnis beträgt");
                Console.WriteLine(zahl1 + zahl2);
                Console.ReadLine();
            }
            //Wenn die Antwort "-" ist, wird folgendes ausgeführt:
            if(antwort == "-")
            {
                Console.WriteLine("Geben sie nacheinander 2 Zahlen ein um diese miteinenader zu subtrahieren:\n" +
                    "1. Zahl:");
                decimal zahl1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("\n2. Zahl:");
                decimal zahl2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("\nDas Ergebnis beträgt");
                Console.WriteLine(zahl1 - zahl2);
                Console.ReadLine();
            }
            //Wenn keines der Antworten "+","-" beinhaltet, wird das Programm geschlossen:
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
