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
            Member member = new Member(donorId);
            Title title = new Title(titleName, member);
            library.Donate(title);
            Title donatedTitle = library.GetTitles()[titleName];
            Assert.AreEqual(titleName, title.TitleName);
            Assert.AreEqual(donorId, title.DonorId);
            Assert.AreEqual(1, title.CopyCount);
            Assert.AreEqual(1, library.GetTitlesDonatedByMember(donorId).Count);
        }
    }
}
