using System;
using Calkulator.SingleOperations;
using NUnit.Framework;

namespace Calkulator.Tests.SingleOperation
{
    [TestFixture]
    public class Sine
    {
        [Test]
        public void CalculationTest()
        {
            ISingleOperation calculator = SingleOperationFactory.CreateSingleOperation("sin");
            double result = calculator.Calculate(45);
            Assert.AreEqual(Math.Sqrt(2)/2, result,0.001);
        }
    }
}
