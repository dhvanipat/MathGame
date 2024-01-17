using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName
{
    static class Helpers
    {
        internal static int GetInt()
        {
            bool validInput = false;
            int result;
            do
            {
                var input = Console.ReadLine();
                validInput = int.TryParse(input, out result);
            } while (!validInput);
            return result;
        }
        internal static string GetName()
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            return name;
        }
        internal static int[] GenerateTwoNumbers()
        {
            int[] numbers = new int[2];
            Random random = new Random();

            numbers[0] = random.Next(0, 9);
            numbers[1] = random.Next(0, 9);

            return numbers;
        }
        internal static int[] GenerateTwoNumbersDivision()
        {
            int[] numbers = new int[2];
            Random random = new Random();

            numbers[0] = random.Next(0, 99);
            ;
            do
            {
                numbers[1] = random.Next(1, 99);
            } while (numbers[0] % numbers[1] != 0);

            return numbers;
        }
    }
}
