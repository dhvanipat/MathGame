Console.WriteLine("Enter your name: ");
var name = Console.ReadLine();
var date = DateTime.UtcNow;

Menu(name, date);

void Menu(string name, DateTime date)
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
    """;
    Console.WriteLine(prompt);
    var gameSelected = Console.ReadLine();
    gameSelected = gameSelected.Trim();

    switch (gameSelected)
    {
        case "1":
            AdditionGame();
            break;
        case "2":
            SubtractionGame();
            break;
        case "3":
            MultiplicationGame();
            break;
        case "4":
            DivisionGame();
            break;
        case "5":
            Console.Write("Goodbye!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid input. Please enter a value equal to 1, 2, 3, 4, or 5.");
            break;
    }
}

object DivisionGame()
{
    throw new NotImplementedException();
}

void MultiplicationGame()
{
    throw new NotImplementedException();
}

void SubtractionGame()
{
    throw new NotImplementedException();
}

void AdditionGame()
{

}