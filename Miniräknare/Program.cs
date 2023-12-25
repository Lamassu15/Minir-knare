using System;
using System.Collections.Generic;

namespace CalculatorWithHistory
{
    class Program
    {
        static void Main(string[] args)
        {
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
                string uttryck = $"{firtNumber} {operation} {secondNumber}";

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

                history.Add($"{uttryck} = {results}");

                Console.WriteLine($"Resultatet av {uttryck} är: {results}");

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
