﻿using System;
using Calkulator.SingleOperations;
using NUnit.Framework;

namespace Calkulator.Tests.SingleOperation
{
    [TestFixture]
    public class NaturalLogarithmTests
    {
        [Test]
        public void CalculationTest()
        {
            ISingleOperation calculator = SingleOperationFactory.CreateSingleOperation("log (e)");
            double result = calculator.Calculate(2);
            Assert.AreEqual(0.693147, result, 0.000001);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void CalculationFailTest()
        {
            ISingleOperation calculator = SingleOperationFactory.CreateSingleOperation("log (e)");
            double result = calculator.Calculate(-10);
        }
    }
}
