using System;
 
abstract class Member
{
public string name;
public int memberId;
 
public Member(string name, int memberId)
{
this.name = name;
this.memberId = memberId;
}
 
public abstract int CalculateFee();
}

class StudentMember : Member
{
public StudentMember(string name, int memberId) : base(name, memberId) { }
 
public override int CalculateFee()
{
return 300; 
}
}
 
class RegularMember : Member
{
public RegularMember(string name, int memberId) : base(name, memberId) { }
 
public override int CalculateFee()
{
return 500; 
}
}
 
class Program
{
static void Main(string[] args)
{
Member s1 = new StudentMember("Mim", 101);
Member r1 = new RegularMember("Nafy", 201);
 
Console.WriteLine("Student Member Fee: " + s1.CalculateFee());
Console.WriteLine("Regular Member Fee: " + r1.CalculateFee());
 
Console.ReadLine();
}
}