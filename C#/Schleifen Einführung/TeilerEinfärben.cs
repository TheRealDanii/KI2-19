using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernaufgabe2__Team_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abfragen des Wertes, bei dem die nachfolgende for-Schleife anfangen soll
            Console.WriteLine("Ab wann: ");
            int abwann = Convert.ToInt32(Console.ReadLine());

            //Abfragen des Wertes, bei dem die for-Schleife enden soll
            Console.WriteLine("Bis wann: ");
            int biswann = Convert.ToInt32(Console.ReadLine());

            //Abfragen des Teilers, den die for-Schleife benutzen soll
            Console.WriteLine("Welchen Teiler?: ");
            int teiler = Convert.ToInt32(Console.ReadLine());
            
            /*For-Schleife:
            Variable i, Typ: Integer wird erstellt und auf den bereits abgefragten Wert (abwann) gesetzt
            Solange i kleiner/gleich dem Wert (biswann) ist, wird folgendes ausgeführt
            Nach jedem Durchgang wird i um 1 erhöht*/
            for(int i = abwann; i <= biswann; i++)
            {
                //Wenn i durch den bereits abgefragten Teiler teilbar ist ohne einen Rest zu hinterlassen
                if(i % teiler == 0)
                {
                    //Schrift wird auf Rot gesetzt und die Zahlen werden mit dem Prefix "Eingefärbt" ausgegeben
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Eingefärbt: " + i);
                }
                //Wenn die Bedingung nicht erfüllt ist, wird folgendes ausgeführt
                else
                {
                    //Schrift wird auf Cyan gesetzt und die aktuelle Zahl wird ausgegeben
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(i);
                }
            }
            //Console wird offengehalten
            Console.ReadLine();
        }
    }
}
