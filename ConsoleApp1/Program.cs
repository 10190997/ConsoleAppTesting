using System;
using Solver;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //y = x^2 + n*x + c
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var result = QuadraticSolver.Solve(a, b, c);

            Console.WriteLine($"Корни {result[0]} {result[1]}");
            Console.ReadKey();
        }
    }
}
