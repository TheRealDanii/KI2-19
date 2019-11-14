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
            for(int i=0; i < 100; i++)
            {
                Console.WriteLine("Aktuelle Zahl: " + i);
            }
            Console.ReadKey();
        }
    }
}
