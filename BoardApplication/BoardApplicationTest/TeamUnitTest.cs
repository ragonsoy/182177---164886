using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;

namespace BoardApplicationTest
{
    [TestClass]
    public class TeamUnitTest
    {
        [TestMethod]
        public void TeamGetNameTest()
        {
            Team team = new Team();
            Assert.AreEqual(team.getName(), "Nombre");
        }
    }
}
