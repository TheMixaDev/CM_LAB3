﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Calculation
{
    public class Simpson
    {
        public static double Calculate(Equation.Value equation, Tuple<double, double> bounds, ulong n)
        {
            double even = 0;
            double odd = 0;
            double step = (bounds.Item2 - bounds.Item1) / n;
            for (ulong i = 1; i < n; i++)
            {
                double value = equation(bounds.Item1 + step * i);
                if (i % 2 == 0)
                    even += value;
                else
                    odd += value;
            }
            return step / 3 * (equation(bounds.Item1) + 4 * odd + 2 * even + equation(bounds.Item2));
        }
    }
}
