using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Round2.A.Tests
{
    [TestFixture]
    public class FootballScoreStatsTests
    {
        [Test]
        public void TotalsFootballScoresForTeam()
        {
            FootballScoreStats stats = new FootballScoreStats();
            Assert.AreEqual(6, stats.TeamTotal("Liverpool"));
        }
    }
}
