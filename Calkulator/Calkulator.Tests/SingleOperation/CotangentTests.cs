using Calkulator.SingleOperations;
using NUnit.Framework;

namespace Calkulator.Tests.SingleOperation
{
    [TestFixture]
    public class CotangentTests
    {
        [Test]
        public void CalculationTest()
        {
            ISingleOperation calculator = SingleOperationFactory.CreateSingleOperation("ctg");
            double result = calculator.Calculate(45);
            Assert.AreEqual(1, result);
        }
    }
}
