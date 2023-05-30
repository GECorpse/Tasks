using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class Trigonometry
    {
        public static double Sinus(double a)
        {
            if (a > 0 && a<=360)
            {
                double r = Math.Sin(a);
                return r;
            }
            else
            {
                return 0;
            }
        }
        public static double Cosinus(double a)
        {
            if (a>0 && a <= 360)
            {
                double r = Math.Cos(a);
                return r;
            }
            else { return 0; }
           
        }
        public static double Catangens(double a)
        {
            if (a > 0 && a <= 360)
            {
                double r = 1 / Math.Tan(a);
                return r;
            }
            else return 0;
            
        }
        public static double Tangens(double a)
        {
            if (a > 0 && a <= 360)
            {
                double r = Math.Tan(a);
                return r;
            }
            else {return 0;
            }
        }
    }
}
