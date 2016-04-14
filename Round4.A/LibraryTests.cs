using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Round4.A
{
    [TestFixture]
    public class LibraryTests
    {
        [Test]
        public void DonatedTitlesAreAddedToLibraryWithOneDefaultCopy()
        {
            Library library = new Library();
            String titleName = "Jaws 3D";
            String donorId = "Jason123";
            library.Donate(titleName, donorId);
            Object[] donatedTitle = library.GetTitles()[titleName];
            Assert.AreEqual(titleName, (String)donatedTitle[0]);
            Assert.AreEqual(donorId, (String)donatedTitle[1]);
            Assert.AreEqual(1, (int)donatedTitle[2]);
            Assert.AreEqual(1, library.GetTitlesDonatedByMember(donorId).Count);
        }
    }
}
