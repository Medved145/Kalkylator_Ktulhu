using System;
using Calkulator.SingleOperations;
using NUnit.Framework;

namespace Calkulator.Tests.SingleOperation
{
    [TestFixture]
    public class ArcSineTests
    {
        [Test]
        public void CalculationTest()
        {
            ISingleOperation calculator = SingleOperationFactory.CreateSingleOperation("asin");
            double result = calculator.Calculate(1);
            Assert.AreEqual(90, result, 0.1);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void CalculationFailTest()
        {
            ISingleOperation calculator = SingleOperationFactory.CreateSingleOperation("asin");
            double result = calculator.Calculate(-10);
        }
    }
}
