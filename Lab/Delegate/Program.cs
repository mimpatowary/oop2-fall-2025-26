using System;

namespace Delegate
{

    public delegate int Operation(int a, int b);

    class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static void Calculate(int a, int b, Operation op)
        {
            int result = op(a, b);
            Console.WriteLine("Result: " + result);
        }

        static void Main(string[] args)
        {
            Calculate(5, 3, Add);
            Calculate(5, 3, Subtract);
        }
    }
}
