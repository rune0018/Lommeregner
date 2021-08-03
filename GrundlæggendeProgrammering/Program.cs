using System;
using System.Linq;

namespace GrundlæggendeProgrammering
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string select;
                string firstNumber, secondNumber;
                int result;

                do
                {
                    Console.Write("Enter the first number: ");
                    firstNumber = Console.ReadLine();
                } while (!IsValidNum(firstNumber));

                do
                {
                    Console.Write("Enter the second number: ");
                    secondNumber = Console.ReadLine();
                } while (!IsValidNum(secondNumber));

                Console.WriteLine("Do you want to add, subtract, multiply or divide? ");
                select = Console.ReadLine();
                switch (select)
                {
                    case "+":
                        result = Convert.ToInt32(firstNumber) + Convert.ToInt32(secondNumber);
                        Console.WriteLine(result);
                        break;
                    case "-":
                        result = Convert.ToInt32(firstNumber) - Convert.ToInt32(secondNumber);
                        Console.WriteLine(result);
                        break;
                    case "*":
                        result = Convert.ToInt32(firstNumber) * Convert.ToInt32(secondNumber);
                        Console.WriteLine(result);
                        break;
                    case "/":
                        result = Convert.ToInt32(firstNumber) / Convert.ToInt32(secondNumber);
                        Console.WriteLine(result);
                        break;
                    default:
                        Console.WriteLine("Is not an option");
                        break;
                }
            } while (Continue());
        }

        static private bool IsValidNum(string check)
        {
            if (check.All(char.IsDigit) && !string.IsNullOrWhiteSpace(check))
                return true;
            else
                Console.WriteLine("Is not a valid number, try again");
            return false;
        }

        static private bool Continue()
        {
            Console.Write("Do you want to continue? (Y / N): ");

            ConsoleKeyInfo validate = Console.ReadKey();
            int CurrentLine = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, CurrentLine);
            Console.WriteLine("");

            return validate.Key == ConsoleKey.Y;
        }
    }
}
