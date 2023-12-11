// C# BASIC STRUCTURE
using System;

namespace SchereSteinPapier
{
    class Spiel
    {
        static void Main(string[] args)
        {
            // TYPZUWEISUNG + VARIABLEN-DEFINIERUNG
            string playerName;
            string[] choices = { "Schere", "Stein", "Papier", "Echse", "Spock" };
            Random random = new Random();

            // ERMÖGLICHEN SIE DIE EINGABE DES BENUTZERNAMENS
            Console.WriteLine("Wie heißt du?:");
            playerName = Console.ReadLine();

            while (true)
            {
                // ERMÖGLICHEN SIE DIE AUSWAHL DES SPIELZUGES
                Console.WriteLine("Wähle: Schere, Stein, Papier, Echse oder Spock");
                string playerChoice = Console.ReadLine();

                string computerChoice = choices[random.Next(choices.Length)];
                Console.WriteLine("Der Computer wählt: " + computerChoice);

                // UNENTSCHIEDEN PRÜFUNG
                if (playerChoice == computerChoice)
                {
                Console.WriteLine("Unentschieden!");
                }
            
                // DEFINIERE FÄLLE IN DEM DER SPIELER GEWINNT // ÜBERSETZT: SONST WENN EINER DER FOLGENDEN FÄLLE TRUE IST, AUSGABE DASS SPIELER GEWONNEN HAT//
                // ES WERDEN NUR FÄLLE BETRACHTET IN DENEN DER SPIELER GEWINNT; ALLE ANDEREN FÄLLE BEDEUTEN DASS COMPUTER GEWINNT
                else if ((playerChoice == "Schere" && (computerChoice == "Papier" || computerChoice == "Echse")) ||
                        (playerChoice == "Papier" && (computerChoice == "Stein" || computerChoice == "Spock")) ||
                        (playerChoice == "Stein" && (computerChoice == "Echse" || computerChoice == "Schere")) ||
                        (playerChoice == "Echse" && (computerChoice == "Spock" || computerChoice == "Papier")) ||
                        (playerChoice == "Spock" && (computerChoice == "Schere" || computerChoice == "Stein")))
                {
                Console.WriteLine(playerName + " gewinnt!");
                }
                // FÜR ALLE ANDEREN FÄLLE -> COMPUTER GEWINNT
                else
                {
                Console.WriteLine("Computer gewinnt!");
                }
                Console.WriteLine("Möchten Sie noch einmal spielen? (Ja/Nein)");
                if (Console.ReadLine() != "Ja") // FALLS EINGABE ANDERS ALS "Ja" -> Brechen der while(true) Loop und Ende des Programms
                break;
            }
        }
    }
}