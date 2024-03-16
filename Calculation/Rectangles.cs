using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Calculation
{
    public class Rectangles
    {
        public static double Calculate(Equation.Value equation, Tuple<double, double> bounds, ulong n, double offset)
        {
            double result = 0;
            double step = (bounds.Item2 - bounds.Item1) / n;
            for (ulong i = 0; i < n; i++)
                result += equation(bounds.Item1 + step * (i + offset)) * step;
            return result;
        }
        public static double CalculateLeft(Equation.Value equation, Tuple<double, double> bounds, ulong n)
        {
            return Calculate(equation, bounds, n, 0);
        }
        public static double CalculateRight(Equation.Value equation, Tuple<double, double> bounds, ulong n)
        {
            return Calculate(equation, bounds, n, 1);
        }
        public static double CalculateMiddle(Equation.Value equation, Tuple<double, double> bounds, ulong n)
        {
            return Calculate(equation, bounds, n, 0.5);
        }
    }
}
