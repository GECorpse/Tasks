using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;



namespace DiscountThursdayTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void finalcost2000()
        {
            //Arrange
            string finalcost = "2000";
            decimal finalcostwithdiscount = 2000;
            decimal res;
            //Art
            res=CoffeeHouse9_14.Windows.CartWindow.DiscountThursday(finalcost);
            //Assert
            Assert.AreEqual(res,finalcostwithdiscount);
        }
        [TestMethod]
        public void finalcosti()
        {
            //Arrange
             string finalcost = "i";
            decimal finalcostwithdiscount = 0;
            decimal res;
            //Art
            res = CoffeeHouse9_14.Windows.CartWindow.DiscountThursday(finalcost);
            //Assert
            Assert.AreEqual(res, finalcostwithdiscount);
        }
        [TestMethod]
        public void finalcost100000000000000000000000000000000000000000()
        {
            //Arrange
            string finalcost = "100000000000000000000000000000000000000000";
            decimal finalcostwithdiscount = 0;
            decimal res;
            //Art
            res = CoffeeHouse9_14.Windows.CartWindow.DiscountThursday(finalcost);
            //Assert
            Assert.AreEqual(res, finalcostwithdiscount);
        }

        //MyMath
        [TestMethod]
        public void sumRiada12345678910()
        {
            //Arrange
            int[] riad = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            int sum = 55;
            int res;
            //Art
            res = MyMath.Algebra.sumRiada(riad);
            //Assert
            Assert.AreEqual(res, sum);
        }
        [TestMethod]
        public void sumRiada124()
        {
            //Arrange
            int[] riad = { 124 };

            int sum = 124;
            int res;
            //Art
            res = MyMath.Algebra.sumRiada(riad);
            //Assert
            Assert.AreEqual(res, sum);
        }
        [TestMethod]
        public void uperNumber12345678910()
        {
            //Arrange
            int[] riad = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int uper = 10;
            int res;
            //Art
            res = MyMath.Algebra.uperNumber(riad);
            //Assert
            Assert.AreEqual(res, uper);
        }
        public void uperNumber123151078910()
        {
            //Arrange
            int[] riad = { 1, 2, 3, 1, 5, 10, 7, 8, 9, 10 };
            int uper = 10;
            int res;
            //Art
            res = MyMath.Algebra.uperNumber(riad);
            //Assert
            Assert.AreEqual(res, uper);
        }
        [TestMethod]
        public void lowerNumber12345678910()
        {
            //Arrange
            int[] riad = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int lower = 1;
            int res;
            //Art
            res = MyMath.Algebra.lowerNumber(riad);
            //Assert
            Assert.AreEqual(res, lower);
        }
        [TestMethod]
        public void lowerNumber123456789310()
        {
            //Arrange
            int[] riad = { 1, 2, 3, 4, 5, 6, 7, 8, -93, 10 };
            int lower = -93;
            int res;
            //Art
            res = MyMath.Algebra.lowerNumber(riad);
            //Assert
            Assert.AreEqual(res, lower);
        }
        [TestMethod]
        public void midAref12345678910()
        {
            //Arrange
            int[] riad = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double mid = 5.5;
            double res;
            //Art
            res = MyMath.Algebra.midAref(riad);
            //Assert
            Assert.AreEqual(res, mid);
        }
        [TestMethod]
        public void midAref12345698910()
        {
            //Arrange
            int[] riad = { 1, 2, 3, 4, 5, 6, -9, 8, 9, 10 };
            double mid = 4.6;
            double res;
            //Art
            res = MyMath.Algebra.midAref(riad);
            //Assert
            Assert.AreEqual(res, mid);
        }
        [TestMethod]
        public void squareTriangle11913()
        {
            //Arrange
            double a =11;
            double b = 9;
            double c = 13;
            double square = 15.2377;
            double res;
            //Art
            res = MyMath.Geometry.SquareTriangle(a,b,c);
            //Assert
            Assert.AreEqual(res, square);
        }
        [TestMethod]
        public void squareTriangle4510()
        {
            //Arrange
            double a = 4;
            double b = -5;
            double c = 10;
            double square = 0;
            double res;
            //Art
            res = MyMath.Geometry.SquareTriangle(a, b, c);
            //Assert
            Assert.AreEqual(res, square);
        }
        [TestMethod]
        public void squareTriangle944()
        {
            //Arrange
            double a = 9;
            double b = 4;
            double c = 4;
            double square = 0;
            double res;
            //Art
            res = MyMath.Geometry.SquareTriangle(a, b, c);
            //Assert
            Assert.AreEqual(res, square);
        }
        [TestMethod]
        public void squareSquare6()
        {
            //Arrange
            double a = 6;
            double square = 36;
            double res;
            //Art
            res = MyMath.Geometry.SquareSquare(a);
            //Assert
            Assert.AreEqual(res, square);
        }
        [TestMethod]
        public void squareSquare8()
        {
            //Arrange
            double a = -8;
            double square = 0;
            double res;
            //Art
            res = MyMath.Geometry.SquareSquare(a);
            //Assert
            Assert.AreEqual(res, square);
        }
        [TestMethod]
        public void squareSqRectangle69()
        {
            //Arrange
            double a = 6;
            double b = 9;
            double square = 54;
            double res;
            //Art
            res = MyMath.Geometry.SquareSqRectangle(a,b);
            //Assert
            Assert.AreEqual(res, square);
        }
        [TestMethod]
        public void squareSqRectangle610()
        {
            //Arrange
            double a = 6;
            double b = -10;
            double square = 0;
            double res;
            //Art
            res = MyMath.Geometry.SquareSqRectangle(a, b);
            //Assert
            Assert.AreEqual(res, square);
        }
        [TestMethod]
        public void squareRhoumbus58()
        {
            //Arrange
            double ac = 5;
            double bd = 8;
            double square = 20;
            double res;
            //Art
            res = MyMath.Geometry.SquareRhoumbs(ac,bd);
            //Assert
            Assert.AreEqual(res, square);
        }
        [TestMethod]
        public void squareRhoumbus59()
        {
            //Arrange
            double ac = 5;
            double bd = -9;
            double square = 0;
            double res;
            //Art
            res = MyMath.Geometry.SquareRhoumbs(ac, bd);
            //Assert
            Assert.AreEqual(res, square);
        }
        [TestMethod]
        public void squareRhoumbus6655()
        {
            //Arrange
            double ac = 6.6;
            double bd = 5.5;
            double square = 0;
            double res;
            //Art
            res = MyMath.Geometry.SquareRhoumbs(ac, bd);
            //Assert
            Assert.AreEqual(res, square);
        }
        [TestMethod]
        public void squareCircle6()
        {
            //Arrange
            double r = 6;
            double square = 113.097336;
            double res;
            //Art
            res = MyMath.Geometry.SquareCircle(r);
            //Assert
            Assert.AreEqual(res, square);
        }
        [TestMethod]
        public void squareCircle7()
        {
            //Arrange
            double r = -7;
            double square = 0;
            double res;
            //Art
            res = MyMath.Geometry.SquareCircle(r);
            //Assert
            Assert.AreEqual(res, square);
        }
        [TestMethod]
        public void squareCircle77()
        {
            //Arrange
            double r = 7.7;
            double square = 59.29;
            double res;
            //Art
            res = MyMath.Geometry.SquareCircle(r);
            //Assert
            Assert.AreEqual(res, square);
        }
        [TestMethod]
        public void sinus60()
        {
            //Arrange
            double a = 60;
            double sinus = Math.Sqrt(3)/2;
            double res;
            //Art
            res = MyMath.Trigonometry.Sinus(a);
            //Assert
            Assert.AreEqual(res, sinus);
        }
        [TestMethod]
        public void sinus30()
        {
            //Arrange
            double a = -30;
            double sinus = 0;
            double res;
            //Art
            res = MyMath.Trigonometry.Sinus(a);
            //Assert
            Assert.AreEqual(res, sinus);
        }
        [TestMethod]
        public void sinus370()
        {
            //Arrange
            double a = 370;
            double sinus = 0;
            double res;
            //Art
            res = MyMath.Trigonometry.Sinus(a);
            //Assert
            Assert.AreEqual(res, sinus);
        }
        [TestMethod]
        public void sinus196()
        {
            //Arrange
            double a = 19.6;
            double sinus = 0.68196362006;
            double res;
            //Art
            res = MyMath.Trigonometry.Sinus(a);
            //Assert
            Assert.AreEqual(res, sinus);
        }
        
        [TestMethod]
        public void cosinus30()
        {
            //Arrange
            double a = 30;
            double cosinus = Math.Sqrt(3) / 2;
            double res;
            //Art
            res = MyMath.Trigonometry.Sinus(a);
            //Assert
            Assert.AreEqual(res, cosinus);
        }
        [TestMethod]
        public void cosinus60()
        {
            //Arrange
            double a = -60;
            double cosinus = 0;
            double res;
            //Art
            res = MyMath.Trigonometry.Sinus(a);
            //Assert
            Assert.AreEqual(res, cosinus);
        }
        [TestMethod]
        public void cosinus660()
        {
            //Arrange
            double a = 660;
            double cosinus = 0;
            double res;
            //Art
            res = MyMath.Trigonometry.Sinus(a);
            //Assert
            Assert.AreEqual(res, cosinus);
        }
        [TestMethod]
        public void cosinus324()
        {
            //Arrange
            double a = 32.4;
            double cosinus = 0.55363493353;
            double res;
            //Art
            res = MyMath.Trigonometry.Sinus(a);
            //Assert
            Assert.AreEqual(res, cosinus);
        }
        [TestMethod]
        public void tangens45()
        {
            //Arrange
            double a = 45;
            double tangens = 1;
            double res;
            //Art
            res = MyMath.Trigonometry.Tangens(a);
            //Assert
            Assert.AreEqual(res, tangens);
        }
        [TestMethod]
        public void tangens60()
        {
            //Arrange
            double a = -60;
            double tangens = 0;
            double res;
            //Art
            res = MyMath.Trigonometry.Tangens(a);
            //Assert
            Assert.AreEqual(res, tangens);
        }
        [TestMethod]
        public void tangens440()
        {
            //Arrange
            double a = 440;
            double tangens = 0.07946211988;
            double res;
            //Art
            res = MyMath.Trigonometry.Tangens(a);
            //Assert
            Assert.AreEqual(res, tangens);
        }
        [TestMethod]
        public void tangens4092()
        {
            //Arrange
            double a = 40.92;
            double tangens = 0;
            double res;
            //Art
            res = MyMath.Trigonometry.Tangens(a);
            //Assert
            Assert.AreEqual(res, tangens);
        }
        [TestMethod]
        public void catangen90()
        {
            //Arrange
            double a = 90;
            double catangens = 0;
            double res;
            //Art
            res = MyMath.Trigonometry.Tangens(a);
            //Assert
            Assert.AreEqual(res, catangens);
        }
        [TestMethod]
        public void catangen45()
        {
            //Arrange
            double a = -45;
            double catangens = 0;
            double res;
            //Art
            res = MyMath.Trigonometry.Tangens(a);
            //Assert
            Assert.AreEqual(res, catangens);
        }
        [TestMethod]
        public void catangen450()
        {
            //Arrange
            double a = 450;
            double catangens = 0;
            double res;
            //Art
            res = MyMath.Trigonometry.Tangens(a);
            //Assert
            Assert.AreEqual(res, catangens);
        }
        [TestMethod]
        public void catangen505()
        {
            //Arrange
            double a = 50.5;
            double catangens = 4.18561268727;
            double res;
            //Art
            res = MyMath.Trigonometry.Tangens(a);
            //Assert
            Assert.AreEqual(res, catangens);
        }
    }
}
