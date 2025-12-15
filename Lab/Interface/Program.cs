using System;

interface IPrintable

{
    void Print();
}

interface ISerializable

{
    void Save();
}


class Report : IPrintable, ISerializable

{
    public void Print()
    {

        Console.WriteLine("painting report...");

    }
    public void Save()

    {

        Console.WriteLine("Saving report...");

    }

}
class Program

{
    static void Main()

    {

        Report report = new Report();

        report.Print();

        report.Save();

    }

}
 