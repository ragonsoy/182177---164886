using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;
using System.Collections.Generic;

namespace BoardApplicationTest
{
    [TestClass]
    public class TeamUnitTest
    {
        DateTime dateCreationTeam;
        int maxUserCount;
        List<Board> teamBoards;
        string nameTeam;
        string description;


        [TestInitialize]
        public void Init()
        {
            dataForTeamTest();
        }

        public void dataForTeamTest()
        {
            nameTeam = "Nombre";
            description = "Descripcion";
            dateCreationTeam = new DateTime();
            DateTime.TryParse("1/1/2000", out dateCreationTeam);
            maxUserCount = 1;
            teamBoards = new List<Board>();
        }

        [TestMethod]
        public void TeamGetNameTest()
        {
            Team team = new Team(nameTeam, dateCreationTeam, description, maxUserCount, teamBoards);
            Assert.AreEqual(team.getName(), nameTeam);
        }

        [TestMethod]
        public void TeamSetNameTest()
        {
            Team team = new Team(nameTeam, dateCreationTeam, description, maxUserCount, teamBoards);
            string changeNameTeam = "NombreCambiado";
            team.setName(changeNameTeam);
            Assert.AreEqual(team.getName(), changeNameTeam);
        }

        [TestMethod]
        public void TeamSetNameEmptyTest()
        {
            Team team = new Team(nameTeam, dateCreationTeam, description, maxUserCount, teamBoards);
            string changeNameEmptyTeam = "";
            team.setName(changeNameEmptyTeam);
            Assert.AreEqual(team.getName(), nameTeam);
        }

        [TestMethod]
        public void TeamGetCreationDateTest()
        {
            Team team = new Team(nameTeam, dateCreationTeam, description, maxUserCount, teamBoards);
            Assert.AreEqual(team.getCreationDate(), dateCreationTeam);
        }

        [TestMethod]
        public void TeamSetCreationDateTest()
        {
            Team team = new Team(nameTeam, dateCreationTeam, description, maxUserCount, teamBoards);
            DateTime dateTimeNew = new DateTime();
            DateTime.TryParse("2/1/2000", out dateTimeNew);
            team.setCreationDate(dateTimeNew);
            Assert.AreEqual(team.getCreationDate(), dateTimeNew);
        }

        [TestMethod]
        public void TeamGetDescriptionTest()
        {
            Team team = new Team(nameTeam, dateCreationTeam, description, maxUserCount, teamBoards);
            Assert.AreEqual(team.getDescription(), description);
        }

        [TestMethod]
        public void TeamSetDescriptionTest()
        {
            Team team = new Team(nameTeam, dateCreationTeam, description, maxUserCount, teamBoards);
            string changeDescription = "Descripcion cambiada";
            team.setDescription(changeDescription);
            Assert.AreEqual(team.getDescription(), changeDescription);
        }

        [TestMethod]
        public void TeamGetMaxUserCountTest()
        {
            Team team = new Team(nameTeam, dateCreationTeam, description, maxUserCount, teamBoards);
            Assert.AreEqual(team.getMaxUserCount(), 1);
        }

        [TestMethod]
        public void TeamSetMaxUserCountTest()
        {
            Team team = new Team(nameTeam, dateCreationTeam, description, maxUserCount, teamBoards);
            team.setMaxUserCount(2);
            Assert.AreEqual(team.getMaxUserCount(), 2);
        }              

    }
}
