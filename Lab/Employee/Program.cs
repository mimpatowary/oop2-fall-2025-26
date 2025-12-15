using System;
 
abstract class Employee
{
 public double basicSalary;
 
 public Employee(double basicSalary)
 {
 this.basicSalary = basicSalary;
 }
 
 
 public abstract double GetTotalSalary();
}
 

class Manager : Employee
{
 public Manager(double basicSalary) : base(basicSalary) { }
 
 public override double GetTotalSalary()
 {
 return basicSalary + 2000;
 }
}
 
class Worker : Employee
{
 public Worker(double basicSalary) : base(basicSalary) { }
 
 public override double GetTotalSalary()
 {
 return basicSalary + 800;
 }
}
 
class Program
{
 static void Main(string[] args)
 {
 Employee m = new Manager(15000);
 Employee w = new Worker(10000);
 
 Console.WriteLine("Manager Total Salary: " + m.GetTotalSalary());
 Console.WriteLine("Worker Total Salary: " + w.GetTotalSalary());
 
 Console.ReadLine();
 }
}
 