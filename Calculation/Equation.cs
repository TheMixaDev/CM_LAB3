using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Calculation
{
    public class Equation
    {
        public delegate double Value(double x);
        public delegate double ValueBounded(double x, Tuple<double, double> limits);
        public const double STEP = 0.00000001;

        private ValueBounded rawFunction;
        private ValueBounded function;
        private string lable;

        internal ValueBounded Function { get => function; }

        public Equation(Value value, string lable, double symmetrical = Double.NaN)
        {
            this.rawFunction = (x, limits) =>
            {
                if(!Double.IsNaN(symmetrical))
                {
                    Tuple<double, double> movedBounds = new Tuple<double, double>(limits.Item1 - symmetrical, limits.Item2 - symmetrical);
                    if(movedBounds.Item1 < 0 && movedBounds.Item2 > 0)
                    {
                        if (Math.Abs(x - symmetrical) < Math.Min(Math.Abs(movedBounds.Item1), Math.Abs(movedBounds.Item2)))
                            return 0;
                    }
                }
                return value(x);
            };
            this.function = (x, limits) =>
            {
                double result;
                try
                {
                    result = rawFunction(x, limits);
                    if (!CheckLimit(x, limits))
                        throw new Exception();
                } catch
                {
                    throw new NotFiniteNumberException();
                }
                ExceptionIfInvalid(result);
                return result;
            };
            this.lable = lable;
        }

        public bool CheckLimit(double x, Tuple<double, double> limits)
        {
            double value = rawFunction(x, limits);
            double leftValue = rawFunction(x - STEP, limits);
            double rightValue = rawFunction(x + STEP, limits);
            ExceptionIfInvalid(value);
            ExceptionIfInvalid(leftValue);
            ExceptionIfInvalid(rightValue);
            if(Math.Abs(Math.Abs(value - leftValue) - Math.Abs(rightValue - value)) > 1)
                return false;
            return true;
        }

        public void ExceptionIfInvalid(double result)
        {
            if (Double.IsNaN(result) || Double.IsInfinity(result) || Double.IsNegativeInfinity(result))
                throw new NotFiniteNumberException();
        }

        public double Derivative(double x, Tuple<double, double> limits)
        {
            return (Function(x + STEP, limits) - Function(x, limits)) / STEP;
        }

        public double SecondDerivative(double x, Tuple<double, double> limits)
        {
            return (Function(x + STEP, limits) - 2 * Function(x, limits) + Function(x - STEP, limits)) / (STEP * STEP);
        }

        public override string ToString()
        {
            return lable;
        }
    }
}
