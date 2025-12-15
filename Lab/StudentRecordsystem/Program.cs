using System;
 
interface IStudent
{
    void Display();
}
 
class Student : IStudent
{
    private int[] marks = new int[3];
    private string name;
 
    
    public Student(string name)
    {
        this.name = name;
    }
 

    public int this[int index]
    {
        get
        {
            return marks[index];
        }
        set
        {
            marks[index] = value;
        }
    }
 
    
    public void Display()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Marks:");
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine("Subject " + (i + 1) + ": " + marks[i]);
        }
    }
}
 
class Program
{
    static void Main()
    {
        Student s = new Student("Mim ");
 
        s[0] = 85;
        s[1] = 87;
        s[2] = 96;
 
        s.Display();
    }
}

 