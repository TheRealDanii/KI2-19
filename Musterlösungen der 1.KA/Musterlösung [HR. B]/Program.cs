using System;

namespace Musterlösung2_KA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guten Tag.");
            Console.WriteLine("Geben sie den systolischen Wert der ersten Messung ein:");
            decimal s1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Geben sie den diastolischen Wert der ersten Messung ein:");
            decimal d1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Geben sie den systolischen Wert der zweiten Messung ein:");
            decimal s2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Geben sie den diastolischen Wert der zweiten Messung ein:");
            decimal d2 = Convert.ToDecimal(Console.ReadLine());

            decimal ms1 = (s2 + s1) / 2;
            decimal md1 = (d1 + d2) / 2;
            byte ampel = 0;

            if(ms1 > 120 | md1 >= 80)
            {
                ampel++;
            }
            if(ms1>139 | md1 > 89)
            {
                ampel++;
            }
            if(ampel == 2)
            {
                Console.WriteLine("Sie haben Bluthochdruck");
            }
            else if(ampel == 1){
                Console.WriteLine("Sie haben normalen Bluthochdruck");
            }
            else
            {
                Console.WriteLine("Sie haben optimalen Bluthochdruck");
            }
            Console.ReadLine();
        }
    }
}
