

using System;

using System.Globalization;

class Program

{

    static void Main()

    {

        double salary = 0;

        double creditScore = 0;

        bool criminalRecord = false;

        

        while (true)

        {

            Console.Write("Enter your salary: ");

            string? salaryInput = Console.ReadLine()?.Trim();

            if (double.TryParse(salaryInput, out salary) && salary > 0)

            {

                break;

            }

            else

            {

                Console.WriteLine("Invalid input. Please enter numerical values.");

            }

        }

        

        while (true)

        {

            Console.Write("Enter your credit score (0–500): ");

            string? creditScoreInput = Console.ReadLine()?.Trim();

            if (double.TryParse(creditScoreInput, out creditScore))

            {

                if (creditScore >= 0 && creditScore <= 500)

                {

                    if (creditScore >= 300)

                    {

                        break;

                    }

                    else

                    {

                        Console.WriteLine("Sorry! You are not eligible for a loan.");

                    }

                }

                else

                {

                    Console.WriteLine("Credit score must be between 0 and 500.");

                }

            }

            else

            {

                Console.WriteLine("Invalid input. Please enter numerical values.");

            }

        }

        

        while (true)

        {

            Console.Write("Do you have a criminal record? (true/false): ");

            string? criminalInput = Console.ReadLine()?.Trim().ToLower();

            if (bool.TryParse(criminalInput, out criminalRecord))

            {

                if (!criminalRecord)

                {

                    Console.WriteLine("You are eligible for a loan!");

                    break;

                }

                else

                {

                    Console.WriteLine("Sorry, applicants with a criminal record are not eligible.");

                    return;

                }

            }

            else

            {

                Console.WriteLine("Please type 'true' or 'false'.");

            }

        }

        

        Console.Write("Enter loan amount: ");

        string? loanAmountInput = Console.ReadLine()?.Trim();

        double loanAmount = double.Parse(loanAmountInput ?? "0");

        if (loanAmount <= (2 * salary))

        {

         

            Console.Write("Enter annual interest rate (in %): ");

            string? interestInput = Console.ReadLine()?.Trim();

            double interestRate = double.Parse(interestInput ?? "0") / 100;

          

            Console.Write("Enter loan period in years: ");

            string? loanTermInput = Console.ReadLine()?.Trim();

            int loanTerm = int.Parse(loanTermInput ?? "0") * 12;

            

            double monthlyPayment =

                (loanAmount * (interestRate / 12) * Math.Pow(1 + (interestRate / 12), loanTerm)) /

                (Math.Pow(1 + (interestRate / 12), loanTerm) - 1);

            double totalPaid = monthlyPayment * loanTerm;

            double totalInterest = totalPaid - loanAmount;

            CultureInfo bdCulture = new CultureInfo("bn-BD");

           

            Console.WriteLine("\n=== Mortgage Summary ===");

            Console.WriteLine($"Monthly Salary: {salary.ToString("C", bdCulture)}");

            Console.WriteLine($"Credit Score: {creditScore}");

            Console.WriteLine($"Criminal Record: {criminalRecord}");

            Console.WriteLine($"Loan Amount: {loanAmount.ToString("C", bdCulture)}");

            Console.WriteLine($"Monthly Payment: {monthlyPayment.ToString("C", bdCulture)}");

            Console.WriteLine($"Total Paid: {totalPaid.ToString("C", bdCulture)}");

            Console.WriteLine($"Total Interest: {totalInterest.ToString("C", bdCulture)}");

        }

        else

        {

            Console.WriteLine("\nYour loan must be less than or equal to twice your salary.");

            Console.WriteLine("Sorry! You are not eligible for this amount.");

        }

    }

}
 