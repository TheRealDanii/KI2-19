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
            Console.WriteLine("Ab wann: ");
            int abwann = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bis wann: ");
            int biswann = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Welchen Teiler?: ");
            int teiler = Convert.ToInt32(Console.ReadLine());
            

            for(int i = abwann; i<= biswann; i++)
            {
                if(i % teiler == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Eingefärbt: " + i);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
