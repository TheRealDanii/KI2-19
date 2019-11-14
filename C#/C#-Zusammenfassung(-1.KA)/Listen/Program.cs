// Author: Michi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DruckerVerwaltungList {
    class Program {
        static void Main(string[] args) {
            List<String[]> druckerListe = new List<String[]>();

            String[] Drucker1 = new String[2];
            String[] Drucker2 = new String[2];
            String[] Drucker3 = new String[2];

            // Eingabe - Drucker 1
            Console.WriteLine("Geben Sie das Modell von Drucker Nr. 1 ein:");
            Drucker1[0] = Console.ReadLine();
            Console.WriteLine("Geben Sie den Raum von Drucker Nr. 1 ein:");
            Drucker1[1] = Console.ReadLine();
            druckerListe.Add(Drucker1);

            // Eingabe - Drucker 2
            Console.WriteLine("Geben Sie das Modell von Drucker Nr. 2 ein:");
            Drucker2[0] = Console.ReadLine();
            Console.WriteLine("Geben Sie den Raum von Drucker Nr. 2 ein:");
            Drucker2[1] = Console.ReadLine();
            druckerListe.Add(Drucker2);

            // Eingabe - Drucker 3
            Console.WriteLine("Geben Sie das Modell von Drucker Nr. 3 ein:");
            Drucker3[0] = Console.ReadLine();
            Console.WriteLine("Geben Sie den Raum von Drucker Nr. 3 ein:");
            Drucker3[1] = Console.ReadLine();
            druckerListe.Add(Drucker3);

            Console.WriteLine(); // designbedingte Leerzeile

            // Ausgabe - Drucker 1
            Console.WriteLine("Drucker 1:");
            Console.WriteLine("Modell: " + druckerListe[0][0]);
            Console.WriteLine("Raum: " + druckerListe[0][1] + "\n");

            // Ausgabe - Drucker 2
            Console.WriteLine("Drucker 2:");
            Console.WriteLine("Modell: " + druckerListe[1][0]);
            Console.WriteLine("Raum: " + druckerListe[1][1] + "\n");

            // Ausgabe - Drucker 3
            Console.WriteLine("Drucker 3:");
            Console.WriteLine("Modell: " + druckerListe[2][0]);
            Console.WriteLine("Raum: " + druckerListe[2][1]);

            Console.ReadKey();
        }
    }
}
