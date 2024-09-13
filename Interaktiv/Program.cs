﻿using System;

/* Struktur:
   Korridor -- hangaren -- räddning
             \
              \-- reaktorrummet -- explosion
                                 \
                                  \-- #winning
*/

string choice = "";

Console.WriteLine("Du står i en välbekant korridor. Grå väggar, grått golv. Ett larm ljuder genom rymdskeppet. Något är fel med reaktorn!");
Console.WriteLine("På din högra sida finns en affish: \"KOM IHÅG: RÖTT ÄR SÖTT, GRÖNT ÄR OSKÖNT\"");
Console.WriteLine("Till vänster finns dörren som leder till reaktorrummet.");
Console.WriteLine("Följer du korridoren rakt framåt så kommer du till hangaren, där livbåtarna finns.");
Console.WriteLine("Vart går du? Framåt eller vänster?");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "framåt")
{
  Console.WriteLine("Du kommer till hangaren. Det finns en livbåt kvar.");
  Console.WriteLine("Du hoppar in i livbåten och stänger luckan efter dig.");
  Console.WriteLine("Fingrarna dansar över kontrollerna, och systemen aktiveras.");
  Console.WriteLine("Livbåten skjuts ut ur skeppet precis i tid - bakom dig sprängs rymdskeppet i en enorm atomexplosion.");
  Console.WriteLine("Du lever, men du vet att företaget kommer att hålla dig ansvarig för skeppet - du kommer att vara skuldsatt resten av livet. Om inte radioaktiviteten från explosionen just gjort dig steril så hade dessutom dina barn och barnbarn fått ärva skulden.");
}
else if (choice == "vänster")
{
  Console.WriteLine("Du kommer in i reaktorrummet.");
  Console.WriteLine("Röda larmlampor blinkar, och du ser att reaktorn snart kommer att explodera.");
  Console.WriteLine("På en skärm blinkar frågan \"RESET REACTOR SYSTEMS?\"");
  Console.WriteLine("Under skärmen finns två knappar. En röd, en grön. Det står inget på dem som antyder vilken som är \"ja\" och vilken som är \"nej\".");
  Console.WriteLine("Trycker du på röd eller grön knapp?");

  choice = Console.ReadLine();
  choice = choice.ToLower();

  if (choice == "röd")
  {
    Console.WriteLine("Bra jobbat! Du mindes precis i tid att någon på marknadsföringsavdelningen tyckt att rött var en mycket snällare färg och att man därmed bytt färg på alla ja/nej-knappar.");
    Console.WriteLine("Rymdskeppet är räddat och kan åka vidare med sin last av illegala vapen.");
  }
  else if (choice == "grön")
  {
    Console.WriteLine("BOOM! Tyvärr hade du glömt att någon på marknadsföringsavdelningen tyckt att rött var en mycket snällare färg och att man därmed bytt färg på alla ja/nej-knappar.");
    Console.WriteLine("Du är död och rymdskeppet förintat.");
  }
  else
  {
    Console.WriteLine("Din klant! Du skrev inget jag kunde förstå, så nu dör du när reaktorn exploderar.");
  }
}
else
{
  Console.WriteLine("Din klant! Du skrev inget jag kunde förstå, så nu dör du när reaktorn exploderar.");
}

Console.WriteLine("Tryck ENTER för att avsluta.");
Console.ReadLine();