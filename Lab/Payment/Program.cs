using System;
 
abstract class Payment
{

public abstract void ProcessPayment(double amount);
}

class BkashPayment : Payment
{
public override void ProcessPayment(double amount)
{
Console.WriteLine("Processing Bkash payment: " + amount);
}
}
 
class CreditCardPayment : Payment
{
public override void ProcessPayment(double amount)
{
Console.WriteLine("Processing Credit Card payment: " + amount);
}
}
 
class Program
{
static void Main(string[] args)
{
Payment p1 = new BkashPayment();
Payment p2 = new CreditCardPayment();
 
p1.ProcessPayment(1500.50);
p2.ProcessPayment(2500.00);
 
Console.ReadLine();
}
}