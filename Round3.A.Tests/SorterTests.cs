using System;
using System.Collections.Generic;
using System.Linq;
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
            array = new Sorter().Sort(SortKind.Bubble, array);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, array);
        }

        [Test]
        public void QuicksortPutsArrayInAscendingOrder()
        {
            int[] array = { 3, 1, 2 };
            array = new Sorter().Sort(SortKind.Quick, array);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, array);
        }

        [Test]
        public void InsertionsortPutsArrayInAscendingOrder()
        {
            int[] array = { 3, 1, 2 };
            array = new Sorter().Sort(SortKind.Insertion, array);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, array);
        }

    }
}
