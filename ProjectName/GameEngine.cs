namespace ProjectName
{
    internal class GameEngine
    {
        int score = 0;
        List<string> games = new List<string>();

        internal void AdditionGame()
        {
            int[] numbers = Helpers.GenerateTwoNumbers();

            Console.WriteLine($"{numbers[0]} + {numbers[1]} = ?");

            int result = Helpers.GetInt();

            if (numbers[0] + numbers[1] == result)
            {
                games.Add($"{DateTime.Now}\tAddition\tWin");
                Success();
            }
            else
            {
                games.Add($"{DateTime.Now}\tAddition\tLose");
                Failure();
            }
        }
        internal void SubtractionGame()
        {
            int[] numbers = Helpers.GenerateTwoNumbers();

            Console.WriteLine($"{numbers[0]} - {numbers[1]} = ?");

            int result = Helpers.GetInt();

            if (numbers[0] - numbers[1] == result)
            {
                games.Add($"{DateTime.Now}\tSubtraction\tWin");
                Success();
            }
            else
            {
                games.Add($"{DateTime.Now}\tSubtraction\tLose");
                Failure();
            }
        }
        internal void MultiplicationGame()
        {
            int[] numbers = Helpers.GenerateTwoNumbers();

            Console.WriteLine($"{numbers[0]} * {numbers[1]} = ?");

            int result = Helpers.GetInt();

            if (numbers[0] * numbers[1] == result)
            {
                games.Add($"{DateTime.Now}\tMultiplication\tWin");
                Success();
            }
            else
            {
                games.Add($"{DateTime.Now}\tMultiplication\tLose");
                Failure();
            }
        }
        internal void DivisionGame()
        {
            // Fix floating point arithmetic errors

            int[] numbers = Helpers.GenerateTwoNumbersDivision();

            Console.WriteLine($"{numbers[0]} / {numbers[1]} = ?");

            double result = Helpers.GetInt();

            if (numbers[0] / numbers[1] == result)
            {
                games.Add($"{DateTime.Now}\tDivision\tWin");
                Success();
            }
            else
            {
                games.Add($"{DateTime.Now}\tDivision\tLose");
                Failure();
            }
        }
        void Success()
        {
            score++;
            Console.WriteLine($"Your answer was correct! Score: {score}");
            Console.WriteLine("Enter any key to continue.");
            Console.ReadLine();
        }
        void Failure()
        {
            Console.WriteLine($"Your answer was incorrect. Score: {score}");
            Console.WriteLine("Enter any key to continue.");
            Console.ReadLine();
        }
        internal void printGames()
        {
            int counter = 1;
            Console.WriteLine("No.\tTime\t\t\tMode\t\tOutcome");
            foreach (string game in games)
            {
                Console.WriteLine(counter + "\t" + game);
            }
        }
    }
}
