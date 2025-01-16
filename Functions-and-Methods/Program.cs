// Create a calculator program with separate methods for addition, subtraction, multiplication, and division.

using System;

namespace csharp
{
    class Calculator
   {
      // Handle addition
      public static double Add(double num1, double num2)
      {
         return num1 + num2;
      }
      // Handle subtraction
      public static double Subtraction(double num1, double num2)
      {
         return num1 - num2;
      }
      // Handle Multiplication
      public static double Multiplication(double num1, double num2)
      {
         return num1 * num2;
      }
      // Handle division
      public static double Division(double num1, double num2)
      {
        return num1 / num2;
      }
      static void Main(string[] args)
      {
        
        Console.WriteLine("Please select one option");
        Console.WriteLine(" 1. Addition\n 2. Subtractio\n 3. Multiplication\n 4. Division\n");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"The sum of {num1} and {num2} is: {Add(num1, num2)}");
                break;
            case 2:
                Console.Write("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"The difference between {num1} and {num2} is: {Subtraction(num1, num2)}");
                break;
            case 3:
                Console.Write("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"The product of {num1} and {num2} is: {Multiplication(num1, num2)}");
                break;
            case 4:
                Console.Write("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Division of {num1} by {num2} is: {Division(num1, num2)}");
                break;

            default:
             Console.WriteLine("Selection not found");
             break;
        }

      }
   }
}
