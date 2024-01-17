using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName
{
    internal class Menu
    {
        GameEngine engine = new GameEngine();
        internal void ProcessMenu(string name, DateTime date)
        {
            Console.WriteLine($"Hello, {name.ToUpper()}! It's {date.DayOfWeek}.");

            var prompt =
            """
            Enter a number to choose an operation to perform:
                (1) Addition
                (2) Subtraction
                (3) Multiplication
                (4) Division
                (5) Quit
                (6) View Game History
            """;
            Console.WriteLine(prompt);
            var gameSelected = Console.ReadLine();
            gameSelected = gameSelected.Trim();

            switch (gameSelected)
            {
                case "1":
                    engine.AdditionGame();
                    break;
                case "2":
                    engine.SubtractionGame();
                    break;
                case "3":
                    engine.MultiplicationGame();
                    break;
                case "4":
                    engine.DivisionGame();
                    break;
                case "5":
                    Console.Write("Goodbye!");
                    Environment.Exit(0);
                    break;
                case "6":
                    engine.printGames();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a value equal to 1, 2, 3, 4, or 5.");
                    break;
            }
        }

    }
}
