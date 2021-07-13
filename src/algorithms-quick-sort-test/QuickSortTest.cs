using algorithms_quick_sort.Sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace algorithms_quick_sort_test
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void ShouldSortArrayWithQuickSortAlgorithm1()
        {
            int[] values = new int[] { 7, 8, 1, 2, 90, 4, 65, 32 };
            QuickSort.Execute(values);
            Assert.AreEqual(1, values[0]);
            Assert.AreEqual(2, values[1]);
            Assert.AreEqual(4, values[2]);
        }

        [TestMethod]
        public void ShouldSortArrayWithQuickSortAlgorithm2()
        {
            int[] values = new int[] { 8, 3, 2, 4, 1, 9, 10, 11 };
            QuickSort.Execute(values);
            Assert.AreEqual(1, values[0]);
            Assert.AreEqual(2, values[1]);
            Assert.AreEqual(3, values[2]);
        }
    }
}
