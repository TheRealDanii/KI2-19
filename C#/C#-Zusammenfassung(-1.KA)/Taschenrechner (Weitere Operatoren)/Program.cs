//Author: Konrad
using System;

namespace Taschenrechner__Erweiter__Auswhälbare_Anzahl_der_Zahlen__2_5_
{
    class Program
    {
        static void Main(string[] args)
        {
        a:
            Console.WriteLine("Guten Tag. Mit welchem Operator wollen sie rechnen (+ ; - ; * ; /)");
            string antwort1 = Console.ReadLine();
            if (antwort1 == "+")
            {
                //Addieren
                Console.WriteLine("Gebe eine Zahl ein: ");
                decimal z1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Gebe die zweite Zahl ein: ");
                decimal z2 = Convert.ToDecimal(Console.ReadLine());

                decimal summe = z1 + z2;
                Console.WriteLine("Das ergebnis beträgt " + summe);
            }
            else
            {
                if (antwort1 == "-")
                //Subtrahieren
                {
                    Console.WriteLine("Gebe die erste Zahl ein: ");
                    decimal z1 = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Gebe die zweite Zahl ein: ");
                    decimal z2 = Convert.ToDecimal(Console.ReadLine());

                    decimal differenz = z1 - z2;
                    Console.WriteLine("Das Ergebnis beträgt " + differenz);
                }
                else
                {
                    if (antwort1 == "*")
                    //Multiplizieren
                    {
                        Console.WriteLine("Gebe eine Zahl ein: ");
                        decimal z1 = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Gebe die zweite Zahl ein: ");
                        decimal z2 = Convert.ToDecimal(Console.ReadLine());

                        decimal produkt = z1 * z2;
                        Console.WriteLine("Das ergebnis beträgt " + produkt);
                    }
                    else
                    {
                        if (antwort1 == "/")
                        //Dividieren
                        {
                            Console.WriteLine("Gebe eine Zahl ein: ");
                            decimal z1 = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Gebe die zweite Zahl ein: ");
                            decimal z2 = Convert.ToDecimal(Console.ReadLine());

                            decimal quotient = z1 / z2;
                            Console.WriteLine("Das ergebnis beträgt " + quotient);
                        }
                        else
                        {
                            goto a;
                            //Wenn etwas anderes als das vorgegebene eingegeben wird, wird wieder nach oben verschoben
                        }
                    }
                }
            }
        b:
            Console.WriteLine("Wollen sie noch eine Rechnung vornehmen? (Ja/Nein)");
            string antwort2 = Console.ReadLine();
            if (antwort2 == "Ja")
            {
                //Neue Rechnung vornehemen
                goto a;

            }
            else if (antwort2 == "Nein")
            {
                Console.WriteLine("Wir bedanken uns, für's Nutzen unseres Taschenrechners.\nDas Programm wird geschlossen.\nSchönen Tag noch");
                //Console schließen lassen
                Console.ReadLine();
            }
            else
            {
                goto b;
            }
        }
    }
}
