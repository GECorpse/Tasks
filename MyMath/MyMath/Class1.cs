using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class Algebra
    {
        public static int sumRiada(int []  r)
        {
            int sum=0;
            for (int i = 0; i < r.Length; i++)
            {
                sum += r[i];
            }
            return sum;
        }
         
        public static int uperNumber(int[] r) 
        {
            int up = 0;
            for (int i = 0; i < r.Length; i++)
            {
                if (i!=r.Length)
                {
                    if (r[i] >= r[i+1])
                    {
                        up = r[i];
                    }
                    else
                    {
                        up = r[i + 1]; 
                    }
                }
            }
            return up;
        }

        public static int lowerNumber(int[] r) 
        {
            int l = 0;
            for (int i = 0; i <= r.Length; i++)
            {
                if (i != r.Length)
                {
                    if (r[i] < r[i + 1])
                    {
                        l = r[i];
                    }
                    else
                    {
                        l = r[i + 1];
                    }
                }
            }
            return l;
        }

        public static double midAref(int[] r)
        {
            double mid = 0;
            for (int i = 0; i < r.Length; i++)
            {
                mid += r[i];
            }
            mid = mid / r.Length;
            return mid;
        }
    }
}
