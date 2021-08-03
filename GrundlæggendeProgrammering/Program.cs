using System;
using System.Linq;

namespace GrundlæggendeProgrammering
{
    class Program
    {
        static void Main(string[] args)
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
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Is not an option");
                    break;
            }
        }

        static private bool IsValidNum(string check)
        {
            if (check.All(char.IsDigit) && !string.IsNullOrWhiteSpace(check))
                return true;
            else
                Console.WriteLine("Is not a valid number, try again");
                return false;
        }
    }
}
