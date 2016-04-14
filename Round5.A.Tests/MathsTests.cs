using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Round5.A.Tests
{
    [TestFixture]
    public class MathsTests
    {

        [Test]
        public void RootOfOneIsOne()
        {
            Assert.AreEqual(1, Maths.Sqrroot(1), 1e-15);
        }

        [Test]
        public void RootOfFourIsTwo()
        {
            Assert.AreEqual(2, Maths.Sqrroot(4), 1e-15);
        }

        [Test]
        public void RootOfNineIsThree()
        {
            Assert.AreEqual(3, Maths.Sqrroot(9), 1e-15);
        }

        [Test]
        public void RootOfSixteenIsFour()
        {
            Assert.AreEqual(4, Maths.Sqrroot(16), 1e-15);
        }

        [Test]
        public void RootOfTwoFiveIsPointFive()
        {
            Assert.AreEqual(0.5, Maths.Sqrroot(0.25), 1e-15);
        }

    }
}
