using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Calculation
{
    public class Simpson
    {
        public static double Calculate(Equation equation, Tuple<double, double> bounds, ulong n)
        {
            EquationUtils.CheckBounds(equation, bounds);
            double even = 0;
            double odd = 0;
            double step = (bounds.Item2 - bounds.Item1) / n;
            for (ulong i = 1; i < n; i++)
            {
                double value = equation.Function(bounds.Item1 + step * i, bounds);
                if (i % 2 == 0)
                    even += value;
                else
                    odd += value;
            }
            return step / 3 * (equation.Function(bounds.Item1, bounds) + 4 * odd + 2 * even + equation.Function(bounds.Item2, bounds));
        }
    }
}
