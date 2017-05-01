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
            Team team = new Team("Nombre", dateTime, "Descripcion", 1);
            Assert.AreEqual(team.getName(), "Nombre");
        }

        [TestMethod]
        public void TeamSetNameTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            Team team = new Team("NombreACambiar", dateTime, "Descripcion", 1);
            team.setName("NombreCambiado");
            Assert.AreEqual(team.getName(), "NombreCambiado");
        }

        [TestMethod]
        public void TeamSetNameEmptyTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            Team team = new Team("NombreACambiar", dateTime, "Descripcion", 1);
            team.setName("");
            Assert.AreEqual(team.getName(), "NombreACambiar");
        }

        [TestMethod]
        public void TeamGetCreationDateTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            Team team = new Team("Nombre", dateTime, "Descripcion", 1);
            Assert.AreEqual(team.getCreationDate(), dateTime);
        }

        [TestMethod]
        public void TeamSetCreationDateTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            Team team = new Team("Nombre", dateTime, "Descripcion", 1);
            DateTime dateTimeNew = new DateTime();
            DateTime.TryParse("2/1/2000", out dateTimeNew);
            team.setCreationDate(dateTimeNew);
            Assert.AreEqual(team.getCreationDate(), dateTimeNew);
        }

        [TestMethod]
        public void TeamGetDescriptionTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            Team team = new Team("Nombre", dateTime, "Descripcion", 1);
            Assert.AreEqual(team.getDescription(), "Descripcion");
        }

        [TestMethod]
        public void TeamSetDescriptionTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            Team team = new Team("Nombre", dateTime, "Descripcion a cambiar", 1);
            team.setDescription("Descripcion cambiada");
            Assert.AreEqual(team.getDescription(), "Descripcion cambiada");
        }

        [TestMethod]
        public void TeamGetMaxUserCountTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            Team team = new Team("Nombre", dateTime, "Descripcion", 1);
            Assert.AreEqual(team.getMaxUserCount(), 1);
        }

    }
}
