using System;

namespace TestPrüfung_Arrays_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Drucker = new string[3, 2];

            Console.WriteLine("Bei diesem Programm handelt es sich um eine Musterlösung\n");

            Console.WriteLine("Erster Druckername: ");
            Drucker[0, 0] = Console.ReadLine();

            Console.WriteLine("Raumnummer des ersten Druckers: ");
            Drucker[0, 1] = Console.ReadLine();

            Console.WriteLine("Zweiter Druckername: ");
            Drucker[1, 0] = Console.ReadLine();

            Console.WriteLine("Raumnummer des zweiten Druckers: ");
            Drucker[1, 1] = Console.ReadLine();

            Console.WriteLine("Dritter Druckername: ");
            Drucker[2, 0] = Console.ReadLine();

            Console.WriteLine("Raumnummer des dritten Druckers: ");
            Drucker[2, 1] = Console.ReadLine();

            Console.WriteLine("Die Druckerliste:\n");
            Console.WriteLine("\nDer erste Drucker wurde " + Drucker[0,0] + " genannt und ist in Raum: " + Drucker[0,1]);
            Console.WriteLine("Der erste Drucker wurde " + Drucker[1, 0] + " genannt und ist in Raum: " + Drucker[1, 1]);
            Console.WriteLine("Der erste Drucker wurde " + Drucker[2, 0] + " genannt und ist in Raum: " + Drucker[2, 1]);

            Console.ReadLine();
        }
    }
}
