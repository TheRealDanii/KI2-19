// Author: Konrad Warttmann
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schleifen_Einführung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable i, Typ: Integer wird erstellt und auf 0 gesetzt
            //Solange i kleiner als 100 ist, wird folgendes ausgeführt
            //Nach jedem Durchlauf wird i um 1 erhöht
            for(int i=0; i < 100; i++)
            {
                //Ausgeben der aktuellen Zahl
                Console.WriteLine("Aktuelle Zahl: " + i);
            }
            //Console wird offengelassen
            Console.ReadKey();
        }
    }
}
