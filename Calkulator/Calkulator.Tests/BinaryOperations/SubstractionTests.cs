using Calkulator.BinaryOperations;
using NUnit.Framework;

namespace Calkulator.Tests.BinaryOperations
{
    [TestFixture]
    public class SubstractionTests
    {
        [Test]
        public void CalculationTest()
        {
            IBinaryOperation calculator = BinaryOperationFactory.CreateBinaryOperation("-");
            double result = calculator.Calculate(9.7, 4.8);
            Assert.AreEqual(4.9, result, 0.01);
        }
    }
}
