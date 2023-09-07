using System;

namespace lab3ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            isPerfectSquare(n);
        }

        static void isPerfectSquare(double x)
        {
            Double result = Math.Sqrt(x);
            System.Console.WriteLine("Sqrt"+x+":" + result);
            if (result % 1 == 0)
            {
                Console.WriteLine("patrat Perfect");
            }
            else
            {
                Console.WriteLine("nu este patrat perfect");
            }
           
        }
    }
}
