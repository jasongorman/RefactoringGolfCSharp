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
        [TestCase(1)]
        [TestCase(4)]
        [TestCase(9)]
        [TestCase(16)]
        [TestCase(0.25)]
        public void RootSquaredIsOriginalNumber(double number)
        {
            Assert.AreEqual(Maths.Sqrroot(number) * Maths.Sqrroot(number), number, 1e-15);
        }
    }
}
