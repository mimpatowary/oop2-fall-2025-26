using System.Globalization;

class MortageCalculator

{

    static void Main()

    {

        Console.Write("Enter Principal (loan amount): ");

        double P = double.Parse(Console.ReadLine()!);

        Console.Write("Enter Annual Interest Rate (in %): ");

        double annualRate = double.Parse(Console.ReadLine()!);

        Console.Write("Enter Loan Term (in years): ");

        int years = int.Parse(Console.ReadLine()!);

        // Calculation Section 

        double r = (annualRate / 100) / 12; 

        int n = years * 12;                

        // Formula: M = P * [ r(1+r)^n / ((1+r)^n - 1) ]

        double M = P * (r * Math.Pow(1 + r, n)) / (Math.Pow(1 + r, n) - 1);

        double totalPaid = M * n;

        double totalInterest = totalPaid - P;

     

        CultureInfo bdCulture = new CultureInfo("bn-BD");

        Console.WriteLine("Mortgage Calculation (BD Format)");

        Console.WriteLine($"Monthly Payment: {M.ToString("C", bdCulture)}");

        Console.WriteLine($"Total Paid: {totalPaid.ToString("C", bdCulture)}");

        Console.WriteLine($"Total Interest: {totalInterest.ToString("C", bdCulture)}");

    }

}
