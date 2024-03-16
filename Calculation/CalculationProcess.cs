using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Calculation
{
    public class CalculationProcess
    {
        public static Result Calculate(int method, Equation equation, Tuple<double, double> bounds, double accuracy, ulong starter)
        {
            ulong n = starter;
            double lastResult = Double.NaN;
            int iteration = 0;
            while(iteration < 1000)
            {
                double result = Double.NaN;
                if (method == 0)
                    result = Rectangles.CalculateLeft(equation.Function, bounds, n);
                if (method == 1)
                    result = Rectangles.CalculateRight(equation.Function, bounds, n);
                if (method == 2)
                    result = Rectangles.CalculateMiddle(equation.Function, bounds, n);
                if (method == 3)
                    result = Trapezoid.Calculate(equation.Function, bounds, n);
                if (method == 4)
                    result = Simpson.Calculate(equation.Function, bounds, n);
                if(Double.IsNaN(lastResult) || result - lastResult > accuracy)
                {
                    lastResult = result;
                    n *= 2;
                } else
                    return new Result(n, result);
                iteration++;
            }
            throw new StackOverflowException();
        }
    }
}
