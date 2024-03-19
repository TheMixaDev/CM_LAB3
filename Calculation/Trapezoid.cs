using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Calculation
{
    public class Trapezoid
    {
        public static double Calculate(Equation equation, Tuple<double, double> bounds, ulong n)
        {
            EquationUtils.CheckBounds(equation, bounds);
            double result = 0;
            double step = (bounds.Item2 - bounds.Item1) / n;
            for (ulong i = 1; i < n; i++)
                result += equation.Function(bounds.Item1 + step * i, bounds);
            result *= 2;
            result += equation.Function(bounds.Item1, bounds) + equation.Function(bounds.Item2, bounds);
            result *= step / 2;
            return result;
        }
    }
}
