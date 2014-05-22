using Calkulator.SortingOperations;
using NUnit.Framework;

namespace Calkulator.Tests.SortingOperations
{
    [TestFixture]
    public class SortingAscendingTests
    {
        [Test]
        public void SortOperationTest()
        {
            ISortingOperation sorting = SortingOperationFactory.CreateSortingOperation("<");
            int[] resultTrue = {128, 25, 172, 163};
            int[] resultTest = {25, 128, 163, 172};
            int[] result = sorting.Sort(resultTrue);
            Assert.AreEqual(resultTest, result);
        }

    }
}
