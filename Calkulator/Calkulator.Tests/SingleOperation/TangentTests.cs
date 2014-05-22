using Calkulator.SingleOperations;
using NUnit.Framework;

namespace Calkulator.Tests.SingleOperation
{
    [TestFixture]
    public  class TangentTests
    {
        [Test]
        public void CalculationTest()
        {
            ISingleOperation calculator = SingleOperationFactory.CreateSingleOperation("tg");
            double result = calculator.Calculate(45);
            Assert.AreEqual(1, result, 0.01);
        }
    }
}
