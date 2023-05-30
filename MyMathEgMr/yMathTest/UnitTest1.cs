using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyMath;

namespace yMathTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SquerTest1()
        {
            double a = 1;
            double b = 2;
            double c = 0;
            string roots = "x1 = 0; x2 = -2";
            string result = MyMath.Algebra.Squer(a, b, c);
            Assert.AreEqual(roots, result);
        }

        [TestMethod]
        public void SquerTest2()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            string roots = "x1 = 0; x2 = 0";
            string result = MyMath.Algebra.Squer(a, b, c);
            Assert.AreEqual(roots, result);
        }

        [TestMethod]
        public void SquerTest3()
        {
            double a = 200;
            double b = 6092;
            double c = 6543;
            string roots = "x1 = -29.345; x2 = -1.114";
            string result = MyMath.Algebra.Squer(a, b, c);
            Assert.AreEqual(roots, result);
        }









        //[TestMethod]
        //public void LinUrTest1()
        //{
        //    double a = 1;
        //    double b = 2;

        //    string roots = "x1 = 0; x2 = -2";
        //    string result = MyMath.Algebra.Squer(a, b, c);
        //}
    }
}
