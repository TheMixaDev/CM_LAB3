using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Calculation
{
    public class Trapezoid
    {
        public static double Calculate(Equation.Value equation, Tuple<double, double> bounds, ulong n)
        {
            double result = 0;
            double step = (bounds.Item2 - bounds.Item1) / n;
            for (ulong i = 1; i < n; i++)
                result += equation(bounds.Item1 + step * i);
            result *= 2;
            result += equation(bounds.Item1) + equation(bounds.Item2);
            result *= step / 2;
            return result;
        }
    }
}
