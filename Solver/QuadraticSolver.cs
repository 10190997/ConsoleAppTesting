using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solver
{
    public class QuadraticSolver
    {
        public static double[] Solve(double a, double b, double c)
        {
            var D = b * b - 4 * a * c;
            if (D > 0)
            {
                var x1 = (-b + D) / 2 * a;
                var x2 = (-b - D) / 2 * a;
                return new[] { x1, x2 };
            }
            else if (D == 0)
            {
                var x = -b / 2 * a;
                return new[] { x };
            }
            else
            {
                return new double[0];
            }
        }
    }
}
