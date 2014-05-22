using System;
using Calkulator.SingleOperations;
using NUnit.Framework;

namespace Calkulator.Tests.SingleOperation
{
    [TestFixture]
    public class ArcCosineTests
    {
        [Test]
        public void CalculationTest()
        {
            ISingleOperation calculator = SingleOperationFactory.CreateSingleOperation("acos");
            double result = calculator.Calculate(Math.Sqrt(3)/2);
            Assert.AreEqual(30, result, 0.1);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void CalculationFailTest()
        {
            ISingleOperation calculator = SingleOperationFactory.CreateSingleOperation("acos");
            double result = calculator.Calculate(-10);
        }
    }
}
