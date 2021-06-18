using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação_Prática
{
    public class Bhaskara
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double CalcularBhaskara(double A, double B, double C)
        {
            var delta = CalcularDelta(A, B, C);
            if (delta > 0)
            {
                var x1 = (-B + delta) / 2 * A;
                var x2 = (-B - delta) / 2 * A;
                return x1 > x2 ? x1 : x2;
            }
            else if (delta == 0)
            {
                return 0;
            }

            return -1;
        }
        public double CalcularDelta(double A, double B, double C)
        {
            return Math.Sqrt(Math.Pow(B, 2) - (4 * A * C));
        }
    }
}
