using System;
using Calkulator.BinaryOperations;
using NUnit.Framework;

namespace Calkulator.Tests.BinaryOperations
{
    [TestFixture]
    public class MultiplicationTests
    {
        [Test]
        public void CalculationTest()
        {
            IBinaryOperation calculator = BinaryOperationFactory.CreateBinaryOperation("*");
            double result = calculator.Calculate(2, 5);
            Assert.AreEqual(10, result );
        }
    }
}
