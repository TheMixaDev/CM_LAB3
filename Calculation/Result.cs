using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Calculation
{
    public class Result
    {
        private ulong iterations;
        private double data;

        public ulong Iterations { get => iterations; set => iterations = value; }
        public double Data { get => data; set => data = value; }

        public Result(ulong iterations, double data)
        {
            this.iterations = iterations;
            this.data = data;
        }
    }
}
