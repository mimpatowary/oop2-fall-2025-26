using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Calculator ");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");

            string choice = Console.ReadLine();

            
            if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool valid = true;

            switch (choice)
            {
                case "1":
                    result = a + b;
                    break;

                case "2":
                    result = a - b;
                    break;

                case "3":
                    result = a * b;
                    break;

                case "4":
                    if (b != 0)
                        result = a / b;
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero!");
                        valid = false;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    valid = false;
                    break;
            }

            if (valid)
                Console.WriteLine($"Result = {result}");

            Console.WriteLine();
        }
    }
}
