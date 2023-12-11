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
            Console.WriteLine("Computer wählt: " + computerChoice);

            
        }
    }
}