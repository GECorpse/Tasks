using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvyatovMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = {1,2,3,4,5,6,7,7};
            Console.WriteLine(Geometry.FirstEx(3,4));
            Console.WriteLine(Geometry.SecondEx(7, 9));
            Console.WriteLine(Geometry.ThirdEx(3, 9));
            Console.WriteLine(Geometry.FourthEx(5, 5));
            Console.WriteLine(Geometry.FifthEx(7, 7, 9));

            Console.WriteLine(Trigonometry.FirstTask(17,19));
            Console.WriteLine(Trigonometry.SecondTask(9,11));
            Console.WriteLine(Trigonometry.ThirdTask(3,7));
            Console.WriteLine(Trigonometry.FourthTask(9,13));
            Console.WriteLine(Trigonometry.FifthTask(12,14));
                                          
            //Console.WriteLine(Algebra.FirstAssign());
            Console.WriteLine(Algebra.SecondAssign(21,6));
            Console.WriteLine(Algebra.ThirdAssign(arr));
            Console.WriteLine(Algebra.FourthAssign(arr));
            Console.WriteLine(Algebra.FifthAssign(arr));

            Console.ReadKey();
        }
    }
}
