using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvyatovMath
{
    public class Geometry
    {
        public static double FirstEx(double x,double y)
        {
            double S = (x * y) / 2;
            return S;
        }
        public static double SecondEx(double x,double y)
        {
            double S = (x * y) / 2;
            return S;
        }
        public static double ThirdEx(double x,double y)
        {
            double S = x * y;
            return S;
        }
        public static int FourthEx(double x,double p)
        {
            p = 3.14;
            double S = (x * x) * p;
            return (int)S;
        }
        public static double FifthEx(double x,double y,double z)
        {
            double S = ((x + y) / 2 * z);
            return S;
        }
    }
}
