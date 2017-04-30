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
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            Team team = new Team("Nombre", dateTime);
            Assert.AreEqual(team.getName(), "Nombre");
        }

        [TestMethod]
        public void TeamSetNameTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            Team team = new Team("NombreACambiar", dateTime);
            team.setName("NombreCambiado");
            Assert.AreEqual(team.getName(), "NombreCambiado");
        }

        [TestMethod]
        public void TeamSetNameEmptyTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            Team team = new Team("NombreACambiar", dateTime);
            team.setName("");
            Assert.AreEqual(team.getName(), "NombreACambiar");
        }

        [TestMethod]
        public void TeamGetCreationDateTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            Team team = new Team("Nombre", dateTime);
            Assert.AreEqual(team.getCreationDate(), dateTime);
        }

        [TestMethod]
        public void TeamSetCreationDateTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            Team team = new Team("Nombre", dateTime);
            DateTime dateTimeNew = new DateTime();
            DateTime.TryParse("2/1/2000", out dateTimeNew);
            team.setCreationDate(dateTimeNew);
            Assert.AreEqual(team.getCreationDate(), dateTimeNew);
        }
    }
}
