using System;
using System.Collections;
using System.Collections.Generic;

namespace CalculatorWithHistory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Välkomnande meddelande
            // En lista för att spara historik för räkningar
            // Användaren matar in tal och matematiska operation
            // OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!
            // Ifall användaren skulle dela med 0 visa Ogiltig inmatning!
            // Lägga resultat till listan
            // Visa resultat
            // Fråga användaren om den vill visa tidigare resultat.
            // Visa tidigare resultat
            // Fråga användaren om den vill avsluta eller fortsätta

            //Input / output
            //Lista med historik
            //Kontrollstrukturer
            //Välja lämpligt designmönster
            //Källkodshantering med GIT

            // Ändra färgen på texten i consolen
            Console.ForegroundColor = ConsoleColor.Blue;


            Console.WriteLine();
            Console.WriteLine("*****************************************");
            Console.WriteLine("Välkommen till miniräknaren med historik!");
            Console.WriteLine("*****************************************");
            Console.WriteLine();

            List<string> history = new List<string>();

            while (true)
            {
                Console.Write("Ange ett tal:");
                double firtNumber = Convert.ToDouble(Console.ReadLine());

                Console.Write("Välj en operation ( + , - , * , / ):");
                char operation = Convert.ToChar(Console.ReadLine());

                Console.Write("Ange nästa tal:");
                double secondNumber = Convert.ToDouble(Console.ReadLine());

                double results = 0;
                string calculations = $"{firtNumber} {operation} {secondNumber}";

                switch (operation)
                {
                    case '+':
                        results = firtNumber + secondNumber;
                        break;
                    case '-':
                        results = firtNumber - secondNumber;
                        break;
                    case '*':
                        results = firtNumber * secondNumber;
                        break;
                    case '/':
                        if (secondNumber != 0)
                        {
                            results = firtNumber / secondNumber;
                        }
                        else
                        {
                            Console.WriteLine("Det går inte att dividera med noll!");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Ogiltig operation! Försök igen.");
                        continue;
                }

                history.Add($"{calculations} = {results}");

                Console.WriteLine($"Resultatet av {calculations} är: {results}");

                Console.WriteLine("Vill du fortsätta? (Ja/Nej)");
                string svar = Console.ReadLine();

                if (svar.ToLower() != "ja")
                {
                    Console.WriteLine("Historik över dina beräkningar:");
                    foreach (var item in history)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                }
            }
        }
    }
}
