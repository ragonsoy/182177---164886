using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;
using System.Collections.Generic;

namespace BoardApplicationTest
{
    [TestClass]
    public class TeamUnitTest
    {
        DateTime dateTime;
        int maxUserCount;
        List<User> teamUsers;
        DateTime birthDate;
        User firstUser;
        User secondUser;

        [TestInitialize]
        public void Init()
        {
            dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            maxUserCount = 1;
            teamUsers = new List<User>();
            birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            firstUser = new User("first ", "firstLastName", "firstEmail", birthDate, "firstPassword");
            secondUser = new User("second", "secondLastName", "secondEmail", birthDate, "secondPassword");
        }

        [TestMethod]
        public void TeamGetNameTest()
        {
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            Assert.AreEqual(team.getName(), "Nombre");
        }

        [TestMethod]
        public void TeamSetNameTest()
        {
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            team.setName("NombreCambiado");
            Assert.AreEqual(team.getName(), "NombreCambiado");
        }

        [TestMethod]
        public void TeamSetNameEmptyTest()
        {
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            team.setName("NombreACambiar");
            Assert.AreEqual(team.getName(), "NombreACambiar");
        }

        [TestMethod]
        public void TeamGetCreationDateTest()
        {
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            Assert.AreEqual(team.getCreationDate(), dateTime);
        }

        [TestMethod]
        public void TeamSetCreationDateTest()
        {
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            DateTime dateTimeNew = new DateTime();
            DateTime.TryParse("2/1/2000", out dateTimeNew);
            team.setCreationDate(dateTimeNew);
            Assert.AreEqual(team.getCreationDate(), dateTimeNew);
        }

        [TestMethod]
        public void TeamGetDescriptionTest()
        {
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            Assert.AreEqual(team.getDescription(), "Descripcion");
        }

        [TestMethod]
        public void TeamSetDescriptionTest()
        {
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            team.setDescription("Descripcion cambiada");
            Assert.AreEqual(team.getDescription(), "Descripcion cambiada");
        }

        [TestMethod]
        public void TeamGetMaxUserCountTest()
        {
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            Assert.AreEqual(team.getMaxUserCount(), 1);
        }

        [TestMethod]
        public void TeamSetMaxUserCountTest()
        {
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            team.setMaxUserCount(2);
            Assert.AreEqual(team.getMaxUserCount(), 2);
        }

        [TestMethod]
        public void TeamAddNewUserTest()
        {
            maxUserCount = 2;
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            team.AddNewUser(firstUser);
            team.AddNewUser(secondUser);
            Assert.IsTrue(teamUsers.Contains(secondUser));
        }

        [TestMethod]
        public void TeamAddMoreUsersThanAlowed()
        {
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            team.AddNewUser(firstUser);
            team.AddNewUser(secondUser);
            Assert.IsFalse(teamUsers.Contains(secondUser));
        }

        [TestMethod]
        public void TeamGetTeamUsersTest()
        {
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            Assert.AreEqual(team.getTeamUsers().Count, 0);
        }

    }
}
