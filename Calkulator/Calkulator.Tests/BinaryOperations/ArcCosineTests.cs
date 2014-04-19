using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calkulator.BinaryOperations;
using Calkulator.SingleOperations;
using NUnit.Framework;

namespace Calkulator.Tests.BinaryOperations
{
    [TestFixture]
    public class ArcCosineTests
    {
        [Test]
        public void CalculationTest()
        {
            ISingleOperation calculator = SingleOperationFactory.CreateSingleOperation("acos");
            double result = calculator.Calculate(0);
            Assert.AreEqual(90, result);
        }
    }
}
