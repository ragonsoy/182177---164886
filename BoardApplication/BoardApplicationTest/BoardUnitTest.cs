using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;
using System.Collections.Generic;

namespace BoardApplicationTest
{

    [TestClass]
    public class BoardUnitTest
    {

        [TestMethod]
        public void BoardGetNameTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide);
            Assert.AreEqual(board.getName(), "NombreBoard");
        }

        [TestMethod]
        public void BoardSetNameTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide);
            board.setName("NombreCambiado");
            Assert.AreEqual(board.getName(), "NombreCambiado");
        }

        [TestMethod]
        public void BoardGetBoardTeamTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide);
            Assert.AreEqual(board.getBoardTeam().getName(), "NombreTeam");
        }

        [TestMethod]
        public void BoardSetBoardTeamTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            Team boardNewTeam = new Team("NombreNewTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide);
            board.SetBoardTeam(boardNewTeam);
            Assert.AreEqual(board.getBoardTeam().getName(), "NombreNewTeam");
        }

        [TestMethod]
        public void BoardGetDescriptionTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide);
            Assert.AreEqual(board.getDescription(), "BoardDescripcion");
        }

        [TestMethod]
        public void BoardSetDescriptionTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide);
            board.setDescripcion("BoardDescripcionCambiada");
            Assert.AreEqual(board.getDescription(), "BoardDescripcionCambiada");
        }

        [TestMethod]
        public void BoardGetHeightTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide);
            Assert.AreEqual(board.getHeight(), 10);
        }

        [TestMethod]
        public void BoardSetHeightTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide);
            board.setHeight(6);
            Assert.AreEqual(board.getHeight(), 6);
        }

        [TestMethod]
        public void BoardGetWideTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide);
            Assert.AreEqual(board.getWide(), 10);
        }

        [TestMethod]
        public void BoardSetWideTest()
        {
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide);
            board.setWide(5);
            Assert.AreEqual(board.getWide(), 5);
        }



    }
}
