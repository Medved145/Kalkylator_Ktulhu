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
    }
}
