using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Round1.A.Tests
{
[TestFixture]
public class FibonacciIndexTests {

    [Test]
    [TestCase(0,0)]
    [TestCase(1,1)]
    [TestCase(3,2)]
    [TestCase(4,3)]
    [TestCase(5,5)]
    [TestCase(6,8)]
    [TestCase(7,13)]
    [TestCase(8,21)]
    [TestCase(49,7778742049L)]
	public void FindsIndexOfFibonacciNumber(int expectedIndex, long fibonacci) {
		Assert.AreEqual(expectedIndex, new FibonacciIndex().FindIndexOf(fibonacci));
	}
}

}
