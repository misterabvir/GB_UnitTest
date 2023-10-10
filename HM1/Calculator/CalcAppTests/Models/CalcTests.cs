using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CalcApp.Models.Tests
{
    [TestClass()]
    public class CalcTests
    {
        [TestMethod()]
        public void TestSimpleCalculationPlusPositive()
        {
            Assert.AreEqual(actual: Calc.Calculation(1, 2, '+'), expected: 3);
            Assert.AreEqual(actual: Calc.Calculation(3, 5, '+'), expected: 8);
            Assert.AreEqual(actual: Calc.Calculation(2, 7, '+'), expected: 9);
            Assert.AreEqual(actual: Calc.Calculation(3, 1, '+'), expected: 4);
        }

        [TestMethod()]
        public void TestSimpleCalculationMinusPositive()
        {
            Assert.AreEqual(actual: Calc.Calculation(5, 7, '-'), expected: -2);
            Assert.AreEqual(actual: Calc.Calculation(9, 7, '-'), expected: 2);
            Assert.AreEqual(actual: Calc.Calculation(-7, 5, '-'), expected: -12);
            Assert.AreEqual(actual: Calc.Calculation(6, -5, '-'), expected: 11);
            Assert.AreEqual(actual: Calc.Calculation(-1, -4, '-'), expected: 3);
            Assert.AreEqual(actual: Calc.Calculation(0, 0, '-'), expected: 0);
        }

        [TestMethod()]
        public void TestSimpleCalculationMultiplyPositive()
        {
            Assert.AreEqual(actual: Calc.Calculation(4, 3, '*'), expected: 12);
            Assert.AreEqual(actual: Calc.Calculation(-4, 3, '*'), expected: -12);
            Assert.AreEqual(actual: Calc.Calculation(4, -3, '*'), expected: -12);
            Assert.AreEqual(actual: Calc.Calculation(-4, -3, '*'), expected: 12);
        }

        [TestMethod()]
        public void TestSimpleCalculationDividePositive()
        {
            Assert.AreEqual(actual: Calc.Calculation(4, 2, '/'), expected: 2);
            Assert.AreEqual(actual: Calc.Calculation(5, 2, '/'), expected: 2.5);
            Assert.AreEqual(actual: Calc.Calculation(-4, 2, '/'), expected: -2);
            Assert.AreEqual(actual: Calc.Calculation(4, -2, '/'), expected: -2);
            Assert.AreEqual(actual: Calc.Calculation(7.5, 2.5, '/'), expected: 3);
        }

        [TestMethod()]
        public void TestSimpleCalculationDivideFailExceptionDivideByZero()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Calc.Calculation(4, 0, '/'));
        }

        [TestMethod()]
        public void TestSimpleCalculationDivideFailExceptionWrongOperation()
        {
            Assert.ThrowsException<ArgumentException>(() => Calc.Calculation(4, 4, '&'));
        }

        [TestMethod()]
        public void TestSquareRootFailExceptionNegativeInput()
        {
            Assert.ThrowsException<ArgumentException>(() => Calc.SquareRootExtraction(-2D));
        }

        [TestMethod()]
        public void TestSquareRootPositive()
        {
            Assert.AreEqual(actual: Calc.SquareRootExtraction(25D), expected: 5D);
            Assert.AreEqual(actual: Calc.SquareRootExtraction(100D), expected: 10D);
        }

        [TestMethod()]
        public void TestDiscountPositive()
        {
            Assert.AreEqual(actual: Calc.CalculatingDiscount(100D, 0.05), expected: 95);
        }

        [TestMethod()]
        public void TestDiscountFailExceptionNegativePurchase()
        {
            Assert.ThrowsException<ArgumentException>(() => Calc.CalculatingDiscount(-100D, 0.05));
        }

        [TestMethod()]
        public void TestDiscountFailExceptionDiscountNotInRange()
        {
            Assert.ThrowsException<ArgumentException>(() => Calc.CalculatingDiscount(100D, -0.05));
            Assert.ThrowsException<ArgumentException>(() => Calc.CalculatingDiscount(100D, 1.05));
        }
    }
}