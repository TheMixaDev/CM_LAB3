using Lab2.Calculation;
using Lab2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.UI
{
    public partial class SingleForm : Form
    {
        public static SingleForm instance;
        public Equation[] equations = new Equation[]{
            new Equation((x) => x, "Не выбрано"),
            new Equation((x) => x*x, "y = x²"),
            new Equation((x) => -x*x + 5, "y = -x² + 5"),
            new Equation((x) => x*x*x - x + 4, "y = x³ - x + 4"),
            new Equation((x) => Math.Pow(Math.E, x) - 3d, "y = exp(x) - 3"),
        };
        public SingleForm()
        {
            instance = this;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
            MinimumSize = Size;
            MaximumSize = Size;
            MaximizeBox = false;

            equationBox.DataSource = equations;
            methodBox.SelectedIndex = 0;
            boundBox.TextChanged += ValidateDouble;
            secondBoundBox.TextChanged += ValidateDouble;
            epsilonBox.TextChanged += ValidatePositiveDouble;
            startDivBox.TextChanged += ValidatePositiveInteger;
        }

        private void equationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RerenderButton();
        }

        private double ParseDouble(string text)
        {
            return double.Parse(text.Replace(".", ","));
        }

        private void RerenderButton()
        {
            calculateButton.Enabled = CheckCalculability();
        }
        private bool CheckCalculability()
        {
            if (equationBox.SelectedIndex == 0) return false;
            if (!EquationUtils.IsDoubleValid(boundBox.Text)) return false;
            if (!EquationUtils.IsDoublePositive(epsilonBox.Text)) return false;
            return true;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int method = methodBox.SelectedIndex;
            Result result = null;

            double leftBound = ParseDouble(boundBox.Text);
            double rightBound = ParseDouble(secondBoundBox.Text);
            Tuple<double, double> limit = new Tuple<double, double>(leftBound, rightBound);
            double epsilon = ParseDouble(epsilonBox.Text);
            ulong starter = ulong.Parse(startDivBox.Text);
            Equation equation = (Equation)equationBox.SelectedItem;
            resultLabel.Text = $"Вычисление...";
            calculateButton.Visible = false;
            new Thread(() =>
            {
                try
                {
                    result = CalculationProcess.Calculate(method, equation, limit, epsilon, starter);
                    instance.Invoke(new Action(() =>
                    {
                        calculateButton.Visible = true;
                        resultLabel.Text = $"Результат:\nЗначение интеграла = {EquationUtils.FormatNumber(result.Data)}\nЧисло разбиений = {result.Iterations}";
                    }));
                }
                catch (StackOverflowException)
                {
                    instance.Invoke(new Action(() =>
                    {
                        MessageBox.Show("Превышен лимит итераций", "Ошибка вычислений", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }
                catch (Exception ex)
                {
                    instance.Invoke(new Action(() =>
                    {
                        MessageBox.Show(ex.Message, "Ошибка вычислений", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }
            }).Start();
        }

        public void ValidateDouble(object sender, EventArgs e)
        {
            string text = ((TextBox)sender).Text;
            EquationUtils.SetTextColor((TextBox)sender, EquationUtils.IsDoubleValid(text));
            Rerender();
        }
        public void ValidatePositiveDouble(object sender, EventArgs e)
        {
            string text = ((TextBox)sender).Text;
            EquationUtils.SetTextColor((TextBox)sender, EquationUtils.IsDoublePositive(text));
            Rerender();
        }
        public void ValidatePositiveInteger(object sender, EventArgs e)
        {
            string text = ((TextBox)sender).Text;
            EquationUtils.SetTextColor((TextBox)sender, EquationUtils.IsIntegerPositive(text));
            Rerender();
        }

        public void Rerender()
        {
            RerenderButton();
        }
    }
}
