using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class Geometry
    {
        public static double SquareTriangle(double a, double b, double c)
        {
            if (a + b < c && a + c < b && b + c < a)
            {
                if (a > 0 && b > 0 && c > 0)
                {
                    double p = (a + b + c) / 2;
                    double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    return s;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        public static double SquareSquare(double a)
        {
            if (a >0)
            { 
            double s = a * a;
                return s;
            }
            else
            {
                return 0;
            }
            
        
        }
        public static double SquareSqRectangle(double a, double b)
        {
            if (a > 0 && b > 0)
            {
                double s = a * b;
                return s;
            }
            else
            {
                return 0;
            }
        }
        public static double SquareRhoumbs(double ac, double bd )
        {
            if (ac > 0 && bd > 0)
            {
                double s = (ac * bd) / 2;
                return s;
            }
            else 
            {
                return 0;
            }
        }
        public static double SquareCircle(double r)
        {
            if (r > 0)
            {
                double s = r * r * 3.14;
                return s;
            }
            else 
            { 
                return 0; 
            }  
        }
    }
}
