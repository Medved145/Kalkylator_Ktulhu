using System;
using Calkulator.BinaryOperations;
using NUnit.Framework;

namespace Calkulator.Tests.BinaryOperations
{
    [TestFixture]
    public class SquareRootTests
    {
        [Test]
        public void CalculationTest()
        {
            IBinaryOperation calculator = BinaryOperationFactory.CreateBinaryOperation("√");
            double result = calculator.Calculate(9, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void CalculationFailTest()
        {
            IBinaryOperation calculator = BinaryOperationFactory.CreateBinaryOperation("√");
            double result = calculator.Calculate(-8, -2);
        }
    }
}
