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
            
            // DEFINIERE FÄLLE IN DEM DER SPIELER GEWINNT
            else if ((playerChoice == "Schere" && (computerChoice == "Papier" || computerChoice == "Echse")) ||
                     (playerChoice == "Papier" && (computerChoice == "Stein" || computerChoice == "Spock")) ||
                     (playerChoice == "Stein" && (computerChoice == "Echse" || computerChoice == "Schere")) ||
                     (playerChoice == "Echse" && (computerChoice == "Spock" || computerChoice == "Papier")) ||
                     (playerChoice == "Spock" && (computerChoice == "Schere" || computerChoice == "Stein")))
            {
                Console.WriteLine(playerName + " gewinnt!");
            }
            
        }
    }
}