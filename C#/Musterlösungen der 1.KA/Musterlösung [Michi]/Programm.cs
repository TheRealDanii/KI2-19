using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KA_Muster {
    class Program {
        static void Main(string[] args) {
            ushort[,] messungen = new ushort[2, 2];
            ushort[] messungenMw = new ushort[2];

            // Erste Messung
            Console.WriteLine("Nr. 1");
            Console.Write("syst:");
            messungen[0, 0] = ushort.Parse(Console.ReadLine());
            Console.Write("diast:");
            messungen[0, 1] = ushort.Parse(Console.ReadLine());

            // Zweite Messung
            Console.WriteLine("Nr. 2");
            Console.Write("syst:");
            messungen[1, 0] = ushort.Parse(Console.ReadLine());
            Console.Write("diast:");
            messungen[1, 1] = ushort.Parse(Console.ReadLine());

            // Mittelwert bilden
            messungenMw[0] = (ushort)((messungen[0,0] + messungen[1,0]) / 2);
            messungenMw[1] = (ushort)((messungen[0, 1] + messungen[1, 1]) / 2);

            // Abfragen
            if(messungenMw[0] < 120 && messungenMw[1] < 80) {
                Console.WriteLine("optimal");
            }else if(messungenMw[0] <= 139 && messungenMw[1] <= 89) {
                Console.WriteLine("normal");
            } else {
                Console.WriteLine("hoch");
            }

            Console.ReadKey();
        }
    }
}
