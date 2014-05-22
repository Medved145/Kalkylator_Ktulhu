using Calkulator.SortingOperations;
using NUnit.Framework;

namespace Calkulator.Tests.SortingOperations
{
    [TestFixture]
    public class SortingDescendingTests
    {
        [Test]
        public void SortOperationTest()
        {
            ISortingOperation sorting = SortingOperationFactory.CreateSortingOperation(">");
            int[] resultTrue = { 128, 25, 172, 163 };
            int[] resultTest = { 172, 163, 128, 25 };
            int[] result = sorting.Sort(resultTrue);
            Assert.AreEqual(resultTest, result);
        }
    }
}
