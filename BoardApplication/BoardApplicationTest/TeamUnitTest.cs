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
            Team team = new Team("Nombre");
            Assert.AreEqual(team.getName(), "Nombre");
        }

        [TestMethod]
        public void TeamSetNameTest()
        {
            Team team = new Team("NombreACambiar");
            team.setName("NombreCambiado");
            Assert.AreEqual(team.getName(), "NombreCambiado");
        }

        [TestMethod]
        public void TeamSetNameEmptyTest()
        {
            Team team = new Team("NombreACambiar");
            team.setName("");
            Assert.AreEqual(team.getName(), "NombreACambiar");
        }
    }
}
