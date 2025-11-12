using System;

public class House  

{

    public int YearBuilt { get; set; }

    public double Size { get; set; }



    public House(int yearBuilt, double size)

    {

        YearBuilt = yearBuilt;

        Size = size;

    }

    

    private int HowOld()

    {

        int currentYear = DateTime.Now.Year;

        return currentYear - YearBuilt;

    }



    public bool CanBeSold()

    {

        int age = HowOld();

        return age > 15;

    }



    public void ShowInfo()

    {

        Console.WriteLine();

        Console.WriteLine("--- House Info ---");

        Console.WriteLine($"Year Built: {YearBuilt}, Size: {Size} sqft");

        Console.WriteLine($"Can be sold: {CanBeSold()}");

        Console.WriteLine();

    }

}

class Program

{

    public static void Main()

    {

        Console.Write("Enter the year built of your house: ");

        int yearBuilt = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the size of your house (in sqft): ");

        double size = Convert.ToDouble(Console.ReadLine());



        House house = new House(yearBuilt, size);

        

        house.ShowInfo();

    }

}
 