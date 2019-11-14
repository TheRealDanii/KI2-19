// Author: Michael Mandel
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMailListen {
    class Program {
        static void Main(string[] args) {
						/* Liste der Schüler mit folgender Struktur:
						 * <[Michi, michael.mandel@buhmann.schule], [Konrad, konrad.w@buhmann.schule], [...]>
						 */
            List<string[]> schuelerListe = new List<string[]>();
						/* Char der entweder j/J oder n/N beinhalten soll 
						 * j/J steht für "Ja noch einen erstellen"
						 * n/N steht für "Nein nicht noch einen erstellen"
						 */
            char anotherOne;

						/*
						 * Die do while Schleife fragt nach jedem Durchgang ab, ob noch ein
						 * Schüler hinzugefügt werden soll. Dies wird über den char "anotherOne"
						 * erfasst, welcher am Ende jedes Durchgangs durch einen ReadKey() erfasst wird
						 * Bei jedem Durchgang fügt Sie der "schuelerListe" einen weiteren "schueler" Array hinzu
						 */
            do {
                string[] schueler = new string[2];

                Console.Write("Name: ");
                schueler[0] = Console.ReadLine();
                Console.Write("E-Mail: ");
                schueler[1] = Console.ReadLine();

								// Fügt den Array der Liste hinzu
                schuelerListe.Add(schueler);

                Console.WriteLine("Noch einen Schüler eintragen? (j/n)");
								// ReadKey().KeyChar gibt das Zeichen der gedrückten Taste zurück
                anotherOne = Console.ReadKey().KeyChar;

								// Platzhalter
                Console.WriteLine();

						// Groß- Kleinschreibung wird nicht beachtet
            } while (anotherOne == 'j' || anotherOne == 'J');

						// Platzhalter
            Console.WriteLine();

						// Zu komplex zum erklären
						// Wer sich reinlesen möchte:
						// https://stackoverflow.com/questions/188141/listt-orderby-alphabetical-order/188149#188149
						// https://docs.microsoft.com/en-us/dotnet/api/system.string.compare?view=netframework-4.8#System_String_Compare_System_String_System_String_
            schuelerListe.Sort((x, y) => string.Compare(x[0].Substring(x[0].IndexOf(" ") + 1), y[0].Substring(y[0].IndexOf(" ") + 1)));

						// Gibt für jeden Schüler in der Liste Namen und E-Mail aus
            for (int i = 0; i < schuelerListe.Count; i++) {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;

                if (i % 2 != 0) { // Jede zweite Zeile wird anders formatiert
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Gray;
                }

                Console.Write(schuelerListe[i][0].PadRight(30));
                Console.Write(schuelerListe[i][1]);

								// Platzhalter
                Console.WriteLine();
            }
						
            Console.ReadKey();
        }
    }
}
