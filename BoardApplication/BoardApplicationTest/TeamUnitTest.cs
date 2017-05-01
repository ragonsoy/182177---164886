using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;
using System.Collections.Generic;

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
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            Assert.AreEqual(team.getName(), "Nombre");
        }

        [TestMethod]
        public void TeamSetNameTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            team.setName("NombreCambiado");
            Assert.AreEqual(team.getName(), "NombreCambiado");
        }

        [TestMethod]
        public void TeamSetNameEmptyTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            team.setName("NombreACambiar");
            Assert.AreEqual(team.getName(), "NombreACambiar");
        }

        [TestMethod]
        public void TeamGetCreationDateTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            Assert.AreEqual(team.getCreationDate(), dateTime);
        }

        [TestMethod]
        public void TeamSetCreationDateTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
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
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            Assert.AreEqual(team.getDescription(), "Descripcion");
        }

        [TestMethod]
        public void TeamSetDescriptionTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            team.setDescription("Descripcion cambiada");
            Assert.AreEqual(team.getDescription(), "Descripcion cambiada");
        }

        [TestMethod]
        public void TeamGetMaxUserCountTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            Assert.AreEqual(team.getMaxUserCount(), 1);
        }

        [TestMethod]
        public void TeamSetMaxUserCountTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            team.setMaxUserCount(2);
            Assert.AreEqual(team.getMaxUserCount(), 2);
        }

        [TestMethod]
        public void TeamAddNewUserTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User firstUser = new User("first ", "firstLastName", "firstEmail", birthDate, "firstPassword");
            User secondUser = new User("second", "secondLastName", "secondEmail", birthDate, "secondPassword");

            List<User> teamUsers = new List<User>();
            
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);

            int maxUserCount = 2;

            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            team.AddNewUser(firstUser);
            team.AddNewUser(secondUser);

            Assert.IsTrue(teamUsers.Contains(secondUser));
        }

        [TestMethod]
        public void TeamAddMoreUsersThanAlowed()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User firstUser = new User("first ", "firstLastName", "firstEmail", birthDate, "firstPassword");
            User secondUser = new User("second", "secondLastName", "secondEmail", birthDate, "secondPassword");

            List<User> teamUsers = new List<User>();

            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);

            int maxUserCount = 1;

            Team team = new Team("Nombre", dateTime, "Descripcion", maxUserCount, teamUsers);
            team.AddNewUser(firstUser);
            team.AddNewUser(secondUser);

            Assert.IsFalse(teamUsers.Contains(secondUser));
        }

    }
}
