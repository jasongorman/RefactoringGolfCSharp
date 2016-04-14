using NUnit.Framework;

namespace Round1.A.Tests
{
    [TestFixture]
    public class FibonacciIndexEdgeCaseTests
    {
        [Test]
        public void WhenNumberNotFoundThenIndexIsMinusOne() {
            Assert.AreEqual(-1, new FibonacciIndex().FindIndexOf(7));
        }

        [Test]
        public void CannotFindIndexOfNegativeNumber() {
            Assert.AreEqual(-1, new FibonacciIndex().FindIndexOf(-1));
        }
    }
}