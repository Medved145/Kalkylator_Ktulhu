using Calkulator.SingleOperations;
using NUnit.Framework;

namespace Calkulator.Tests.SingleOperation
{
    [TestFixture]
    public  class CosineTests
    {
        [Test]
        public void CalculationTest()
        {
            ISingleOperation calculator = SingleOperationFactory.CreateSingleOperation("cos");
            double result = calculator.Calculate(60);
            Assert.AreEqual(.5, result, 0.00001);
        }
    }
}
