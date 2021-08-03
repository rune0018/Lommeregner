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
                double resultD;

                Console.WriteLine(new string('-', 30));
                Console.WriteLine("Options: ");
                Console.WriteLine("1: Add the numbers");
                Console.WriteLine("2: Subtract the numbers");
                Console.WriteLine("3: Multiply the numbers");
                Console.WriteLine("4: Divide the numbers");
                Console.WriteLine("5: The power of the number");
                Console.WriteLine(new string('-', 30));
                select = Console.ReadLine();
                
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
                switch (select)
                {
                    case "1":
                        result = Convert.ToInt32(firstNumber) + Convert.ToInt32(secondNumber);
                        Console.WriteLine(result);
                        break;
                    case "2":
                        result = Convert.ToInt32(firstNumber) - Convert.ToInt32(secondNumber);
                        Console.WriteLine(result);
                        break;
                    case "3":
                        result = Convert.ToInt32(firstNumber) * Convert.ToInt32(secondNumber);
                        Console.WriteLine(result);
                        break;
                    case "4":
                        result = Convert.ToInt32(firstNumber) / Convert.ToInt32(secondNumber);
                        Console.WriteLine(result);
                        break;
                    case "5":
                        resultD = Powerof(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber));
                        Console.WriteLine(resultD);
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
        
        static private double Powerof(double firstnum,double secondnum)
        {
            double result = 1;
            for(int i= 0; i < secondnum; i++)
            {
                result *= firstnum;
            }
            return result;
        }
    }
}
