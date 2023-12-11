// C# BASIC STRUCTURE
using System;
// TYPZUWEISUNG + VARIABLEN-DEFINIERUNG
string playerName;
string[] choices = { "Schere", "Stein", "Papier", "Echse", "Spock" };
Random random = new Random();

// ERMÖGLICHEN SIE DIE EINGABE DES BENUTZERNAMENS
Console.WriteLine("Schön dass du hier bist! Wie lautet dein Name? :");
playerName = Console.ReadLine();

while (true)
{
    // ERMÖGLICHEN SIE DIE AUSWAHL DES SPIELZUGES
    Console.WriteLine(playerName + ", bitte Wähle: Schere, Stein, Papier, Echse oder Spock");
    string playerChoice = Console.ReadLine();

    if (Array.IndexOf(choices, playerChoice) == -1)
    {
        Console.WriteLine("Ungültige Eingabe, versuche es noch einmal!");
        continue;
    }

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
        Console.WriteLine("Leider hat der Computer dieses mal gewonnen!");
    }
    Console.WriteLine("Möchtest noch einmal spielen? (Ja/Nein)");
    if (Console.ReadLine() != "Ja") // FALLS EINGABE ANDERS ALS "Ja" -> Brechen der while(true) Loop und Ende des Programms
    {
        Console.WriteLine("Vielen Dank für's Spielen " + playerName + ". Bis zum nächsten mal!");
        break;
    }
}
