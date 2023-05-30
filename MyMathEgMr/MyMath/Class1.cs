using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public static class Algebra
    {
        public static string Squer(double a, double b, double c)
        {
            double x1 = (-b + (Math.Sqrt((b * b) - 4 * a * c))  / (2*a));
            double x2 = (-b - (Math.Sqrt((b * b) - 4 * a * c)) / (2 * a));

            string final = Convert.ToString("x1 = " +x1 +";");
            final += " " + Convert.ToString("x2 = " + x2);
            return final;

        }

        public static double LinUr(double a, double b)
        {
            Double x = -(b / a);
            return x;
        }

        public static int Sum()
        {
            int a = int.Parse(Console.ReadLine());
            int b = a;

            while (a != 0)
            {
                a = int.Parse(Console.ReadLine());
                b += a;
            }
            return b;
        }

        //public static int MaxRow()
        //{ int b = 0;
        //int a = int.Parse(Console.ReadLine());
        //    while (a != 0)
        //    {

        //        a = int.Parse(Console.ReadLine());
        //        if (a >= b)
        //        {
        //            b = a;

        //        }
        //        return b;
        //    }
        //}



        public static int MiddleRow()
        {
            int c = 0;
            int b = 0;
            int a = int.Parse(Console.ReadLine());

            do
            {
                a = int.Parse(Console.ReadLine());
                b += a;
                c++;
            } while (a != 0);

            b /= (c - 1);
            return b;

        }

    }
    public static class Geometry
    {
        public static double STreangl(double a, double b , double c)
        {
            



            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;


        }

        public static double SRightTreangl(double a, double b)
        {
            


            double s = (a * b) / 2;
            return s;      


        }


        public static double SRectngl(double a, double b)
        {
            


            double s = (a * b);
            return s;

        }
        public static double SCircle(double r)
        {
            
            double s = (3.14 * (r * r));
            return s;


        }
        public static double STrapezoid(double a, double b, double c)
        {
         
            double s = 0.5 * (a + b) * Math.Sqrt((c * c) - ((a - b) / 2) * ((a - b) / 2));
           

            return s;


        }
    }
}
