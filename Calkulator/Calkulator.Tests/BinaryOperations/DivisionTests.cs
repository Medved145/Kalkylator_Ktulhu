﻿using Calkulator.BinaryOperations;
using NUnit.Framework;

namespace Calkulator.Tests.BinaryOperations
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void CalculationTest()
        {
            IBinaryOperation calculator = BinaryOperationFactory.CreateBinaryOperation("/");
            double result = calculator.Calculate(15, 5);
            Assert.AreEqual(3, result);
        }
    }
}
