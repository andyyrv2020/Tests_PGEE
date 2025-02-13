using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CategoryAttribute = NUnit.Framework.CategoryAttribute;


namespace Test11Instructions
{
    public class CalculatorTests 
    {
        [Test]
        [Category("Addition")]
        public void TestAddingTwoPositiveIntegerNumbers()
        {
            //Arrange
            int a = 5;
            int b = 9;

            //Act
            double result = Program.Add(a, b);

            //Assert
            Assert.AreEqual(result, 14);
        }

        [Test]
        [Category("Addition")]
        public void TestAddingTwoPositiveFloatingPointNumbers()
        {
            //Arrange
            double a = 5.43;
            double b = 0.33;

            //Act
            double result = Program.Add(a, b);

            //Assert
            Assert.AreEqual(result, 5.76);
        }

        [Test]
        [Category("Addition")]
        public void TestAddingTwoNegativeNumbers()
        {
            //Arrange
            double a = -3.431;
            double b = -3.241;

            //Act
            double result = Program.Add(a, b);

            //Assert
            Assert.AreEqual(result, -6.672, 0.0001);
        }

        [Test]
        [Category("Addition")]
        public void TestAddingTwoZeroes()
        {
            double a = 0;
            double b = 0;

            double result = Program.Add(a, b);
            Assert.AreEqual(result, 0);
        }

        [Test]
        [Category("Addition")]
        public void TestAddingZeroAndNumber()
        {
            double a = 1;
            double b = 0;

            double result = Program.Add(a, b);
            Assert.AreEqual(result, 1);
        }

        [Test]
        [Category("Addition")]
        public void TestAddingOppositeNumbers()
        {
            double a = -5.34;
            double b = 5.34;

            double result = Program.Add(a, b);
            Assert.AreEqual(result, 0);
        }

        [Test]
        [Category("Subtraction")]
        public void TestSubtractionFirstBigger()
        {
            double a = 5;
            double b = 3;

            double result = Program.Subtract(a, b);

            Assert.AreEqual(result, 2);
        }

        [Test]
        [Category("Subtraction")]
        public void TestSubtractionSecondBigger()
        {
            double a = 3;
            double b = 5;

            double result = Program.Subtract(a, b);

            Assert.AreEqual(result, -2);
        }

        [Test]
        [Category("Subtraction")]
        public void TestSubtractZero()
        {
            double a = 3;
            double b = 0;

            double result = Program.Subtract(a, b);

            Assert.AreEqual(result, 3);
        }

        [Test]
        [Category("Subtraction")]
        public void TestSubtractNegativeNumbers()
        {
            double a = -3;
            double b = -5;

            double result = Program.Subtract(a, b);
            Assert.AreEqual(result, 2);
        }

        [Test]
        [Category("Multiplication")]
        public void TestMultiplicationTwoPositiveNumbers()
        {
            double a = 3;
            double b = 2.5;

            double result = Program.Multiply(a, b);

            Assert.AreEqual(result, 7.5);
        }

        [Test]
        [Category("Multiplication")]
        public void TestMultiplicationTwoNegativeNumbers()
        {
            double a = -3;
            double b = -2;
            double result = Program.Multiply(a, b);
            Assert.AreEqual(result, 6);
        }
        [Test]
        [Category("Multiplication")]
        public void TestMultiplicationTwoDifferentSignedNumbers()
        {
            double a = -3;
            double b = 2;
            double result = Program.Multiply(a, b);
            Assert.AreEqual(result, -6);
        }

        [Test]
        [Category("Multiplication")]
        public void TestMultiplicationWithZero()
        {
            double a = 0;
            double b = 3;

            double result = Program.Multiply(a, b);

            Assert.AreEqual(result, 0);
        }

        [Test]
        [Category("Division")]
        public void TestDivisionWithTwoNumbers()
        {
            double a = 3;
            double b = 2;

            double result = Program.Division(a, b);
            Assert.AreEqual(result, 1.5);
        }

        [Test]
        [Category("Division")]
        public void TestDivisionWithBiggerNumber()
        {
            double a = 3;
            double b = 5;

            double result = Program.Division(a, b);

            Assert.AreEqual(result, 0.6);
        }

        [Test]
        [Category("Division")]
        public void TestDivisionZeroByNumber()
        {
            double a = 0;
            double b = 5;
            double result = Program.Division(a, b);
        }

        [Test]
        [Category("Division")]
        public void TestDivisionByZero()
        {
            double a = 5;
            double b = 0;
            Assert.Throws<DivideByZeroException>(() => Program.Division(a, b));

        }

    }
}


