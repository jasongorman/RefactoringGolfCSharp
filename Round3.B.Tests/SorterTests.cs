using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Round3.A.Tests
{
    [TestFixture]
    public class SorterTests
    {

        [Test]
        public void BubblesortPutsArrayInAscendingOrder()
        {
            int[] array = { 3, 1, 2 };
            array = new Sorter().Sort(new BubbleSort(), array);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, array);
        }

        [Test]
        public void QuicksortPutsArrayInAscendingOrder()
        {
            int[] array = { 3, 1, 2 };
            array = new Sorter().Sort(new QuickSort(), array);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, array);
        }

        [Test]
        public void InsertionsortPutsArrayInAscendingOrder()
        {
            int[] array = { 3, 1, 2 };
            array = new Sorter().Sort(new InsertionSort(), array);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, array);
        }

    }
}
