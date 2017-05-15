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
        Team team;
        Team teamTwo;
        int height;
        int width;
        Board board;
        Board boardPrueba;
        DateTime birthDateUser;
        string nameUser;
        string lastNameUser;
        string emailUser;
        string passwordUser;
        UserCollaborator creatorUser;
        UserCollaborator user;

        [TestInitialize]
        public void Init()
        {
            dataForUserTest();
            dataForBoardTest();
            dataForTeamTest();
        }

        public void dataForBoardTest()
        {
            height = 10;
            width = 10;
            board = new Board("NombreBoard", "BoardDescripcion", height, width, creatorUser);
            boardPrueba = new Board("NombreBoardPrueba", "BoardDescripcion", height, width, creatorUser);
        }

        public void dataForTeamTest()
        {
            nameTeam = "Nombre";
            description = "Descripcion";
            dateCreationTeam = new DateTime();
            DateTime.TryParse("1/1/2000", out dateCreationTeam);
            maxUserCount = 1;
            teamBoards = new List<Board>();
            team = new Team(nameTeam, dateCreationTeam, description, maxUserCount);
            teamTwo = new Team(nameTeam, dateCreationTeam, description, 0);
        }

        public void dataForUserTest()
        {
            birthDateUser = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDateUser);
            nameUser = "Nombre";
            lastNameUser = "Apellido";
            emailUser = "Email";
            passwordUser = "Password";
            creatorUser = new UserCollaborator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser);
            user = new UserCollaborator(nameUser, lastNameUser, "userEmail", birthDateUser, passwordUser);
        }

        [TestMethod]
        public void TeamGetNameTest()
        {
            Assert.AreEqual(team.getName(), nameTeam);
        }

        [TestMethod]
        public void TeamSetNameTest()
        {
            string changeNameTeam = "NombreCambiado";
            team.setName(changeNameTeam);
            Assert.AreEqual(team.getName(), changeNameTeam);
        }

        [TestMethod]
        public void TeamSetNameEmptyTest()
        {
            string changeNameEmptyTeam = "";
            team.setName(changeNameEmptyTeam);
            Assert.AreEqual(team.getName(), nameTeam);
        }

        [TestMethod]
        public void TeamGetCreationDateTest()
        {
            Assert.AreEqual(team.getCreationDate(), dateCreationTeam);
        }

        [TestMethod]
        public void TeamSetCreationDateTest()
        {
            DateTime dateTimeNew = new DateTime();
            DateTime.TryParse("2/1/2000", out dateTimeNew);
            team.setCreationDate(dateTimeNew);
            Assert.AreEqual(team.getCreationDate(), dateTimeNew);
        }

        [TestMethod]
        public void TeamGetDescriptionTest()
        {
            Assert.AreEqual(team.getDescription(), description);
        }

        [TestMethod]
        public void TeamSetDescriptionTest()
        {
            string changeDescription = "Descripcion cambiada";
            team.setDescription(changeDescription);
            Assert.AreEqual(team.getDescription(), changeDescription);
        }

        [TestMethod]
        public void TeamGetMaxUserCountTest()
        {
            Assert.AreEqual(team.getMaxUserCount(), 1);
        }

        [TestMethod]
        public void TeamSetMaxUserCountTest()
        {
            team.setMaxUserCount(2);
            Assert.AreEqual(team.getMaxUserCount(), 2);
        }

        [TestMethod]
        public void TeamEqualsTest()
        {
            Assert.IsTrue(team.Equals(team));
        }

        [TestMethod]
        public void TeamToStringTest()
        {
            Assert.AreEqual(team.getName(), team.ToString());
        }

        [TestMethod]
        public void TeamAddUserToTeamTrueTest()
        {
            Assert.IsFalse(teamTwo.AddUserToTeam());
        }

        [TestMethod]
        public void TeamAddUserToTeamFalseTest()
        {
            Assert.IsTrue(team.AddUserToTeam());
        }

        [TestMethod]
        public void TeamAddBoardTest()
        {
            team.AddBoard(board);
            Assert.AreEqual(team.getBoards().Count, 1);
        }

        [TestMethod]
        public void TeamExistBoardTest()
        {
            team.AddBoard(board);
            Assert.IsTrue(team.ExistBoard(board));
        }

        [TestMethod]
        public void TeamGetBoardsTest()
        {
            team.AddBoard(board);
            Assert.AreEqual(team.getBoards().Count, 1);
        }

        [TestMethod]
        public void TeamGetBoardTest()
        {
            team.AddBoard(board);
            team.AddBoard(boardPrueba);
            Assert.AreEqual(team.GetBoard("NombreBoardPrueba"), boardPrueba);
        }

        [TestMethod]
        public void TeamRemoveBoardTest()
        {
            team.AddBoard(board);
            team.AddBoard(boardPrueba);
            team.RemoveBoard(board);
            Assert.AreEqual(team.GetBoard("NombreBoardPrueba"), boardPrueba);
        }

        [TestMethod]
        public void TeamUniqueUserTest()
        {
            if(teamNotFull())
                user.AddToTeam(team);
            Assert.IsTrue(team.UniqueUser());
        }

        private bool teamNotFull()
        {
            return team.AddUserToTeam();
        }
    }
}
