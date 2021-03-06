﻿using System;
using Calkulator.BinaryOperations;
using NUnit.Framework;

namespace Calkulator.Tests.BinaryOperations
{
    [TestFixture]
    public class LogarithmTests
    {
        [Test]
        public void CalculationTest()
        {
            IBinaryOperation calculator = BinaryOperationFactory.CreateBinaryOperation("log (s)");
            double result = calculator.Calculate(8, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void CalculationFailTest()
        {
            IBinaryOperation calculator = BinaryOperationFactory.CreateBinaryOperation("log (s)");
            double result = calculator.Calculate(-8, -2);
        }
    }
}
