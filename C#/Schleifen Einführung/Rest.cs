// Author: Konrad Warttmann
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernaufgabe_Team_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable i, Typ: Integer wird erstellt und wird auf 100 gesetzt
            //Solange i kleiner/gleich 200 ist wird folgendes ausgeführt
            //Nach jedem Durchlauf wird i um 1 erhöht
            for(int i = 100; i <=200; i++)
            {
                //Wenn i / 3 keinen rest ergibt, wird folgendes ausgeführt
                if(i % 3 == 0)
                {
                    //Ausgeben von i, wenn i durch 3 ohne Rest teilbar ist
                    Console.WriteLine(i + " ist durch 3 teilbar ohne einen Rest zu hinterlassen!");
                }
            }
            //Console wird offengelassen
            Console.ReadLine();
        }
    }
}
