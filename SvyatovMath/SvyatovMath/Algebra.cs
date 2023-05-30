using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SvyatovMath
{
    public class Algebra
    {
        public static double SecondAssign(double a, double b)
        {
            return -a / b;
        }
        public static double ThirdAssign(double[] arr)
        {
            return arr.Sum();
        }
        public static double FourthAssign(double[] arr)
        {
            return arr.Max();
        }
        public static double FifthAssign(double[] arr)
        {
            return arr.Average();
        }
    }
}
