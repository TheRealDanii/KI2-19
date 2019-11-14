using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlleSchleifen {
    class Program {
        static void Main(string[] args) {

						// Vorgegebene Liste mit Namen
            List<string> listOfNames = new List<string>() 
            {
                "Alex",
                "Jan",
                "Konrad"
            };

					
            Console.WriteLine("-= foreach =-");
						// Für jeden Namen in der Namens Liste
            foreach(string name in listOfNames) {
                Console.WriteLine(name);
            }

						// Platzhalter
            Console.WriteLine();

            Console.WriteLine("-= for =-");
						// Solange i < als die Anzahl der Elemente in der Namens Liste ist,
						// gibt er den Namen aus und zählt i+1 
            for (int i = 0; i<listOfNames.Count; i++) {
                Console.WriteLine(listOfNames[i]);
            }

						// Platzhalter
            Console.WriteLine();

            Console.WriteLine("-= while =-");
						// Zähler muss außerhalb definiert werden (nur bei der while-Schleife)
            int j = 0;
						// Solange wie j < als die Anzahl der Elemente in der Namens Liste ist,
						// gibt er den Namen aus und zählt j+1 (manuell innerhalb der Schleife) 
            while (j < listOfNames.Count) {
                Console.WriteLine(listOfNames[j]);
                j++;
            }
						
            Console.ReadKey();
        }
    }
}
