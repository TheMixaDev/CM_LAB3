using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Calculation
{
    public static class EquationUtils
    {
        public const int LIMIT_ITERATIONS = 2000;

        public static bool IsDoubleValid(string text)
        {
            return double.TryParse(text.Replace(".", ","), out double result);
        }
        public static bool IsDoublePositive(string text)
        {
            if (double.TryParse(text.Replace(".", ","), out double result))
                return result > 0;
            return false;
        }

        public static bool IsIntegerPositive(string text)
        {
            if (ulong.TryParse(text, out ulong result))
                return result > 0;
            return false;
        }

        public static void SetTextColor(TextBox textBox, bool valid)
        {
            if (valid)
                textBox.BackColor = SystemColors.Window;
            else
                textBox.BackColor = Color.LightSalmon;
        }

        public static string FormatNumber(double number)
        {
            if (number.ToString().Contains("E"))
            {
                string[] parts = number.ToString().Split('E');
                double coefficient = double.Parse(parts[0]);
                int exponent = int.Parse(parts[1]);

                return $"{coefficient} · 10^({exponent})";
            }

            return number.ToString();
        }

        public static void CheckBounds(Equation equation, Tuple<double, double> bounds)
        {
            equation.Function(bounds.Item1, bounds);
            equation.Function(bounds.Item2, bounds);
        }
    }
}
