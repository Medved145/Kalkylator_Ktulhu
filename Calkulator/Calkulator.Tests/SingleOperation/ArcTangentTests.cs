using Calkulator.SingleOperations;
using NUnit.Framework;

namespace Calkulator.Tests.SingleOperation
{
    [TestFixture]
    public class ArcTangentTests
    {
        [Test]
        public void CalculationTest()
        {
            ISingleOperation calculator = SingleOperationFactory.CreateSingleOperation("atg");
            double result = calculator.Calculate(1);
            Assert.AreEqual(45, result, 0.1);
        }
    }
}
