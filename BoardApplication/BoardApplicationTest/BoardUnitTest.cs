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
            List<BoardElement> boardElements = new List<BoardElement>();
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide, boardElements);
            Assert.AreEqual(board.getName(), "NombreBoard");
        }

        [TestMethod]
        public void BoardSetNameTest()
        {
            List<BoardElement> boardElements = new List<BoardElement>();
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide, boardElements);
            board.setName("NombreCambiado");
            Assert.AreEqual(board.getName(), "NombreCambiado");
        }

        [TestMethod]
        public void BoardGetBoardTeamTest()
        {
            List<BoardElement> boardElements = new List<BoardElement>();
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide, boardElements);
            Assert.AreEqual(board.getBoardTeam().getName(), "NombreTeam");
        }

        [TestMethod]
        public void BoardSetBoardTeamTest()
        {
            List<BoardElement> boardElements = new List<BoardElement>();
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            Team boardNewTeam = new Team("NombreNewTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide, boardElements);
            board.SetBoardTeam(boardNewTeam);
            Assert.AreEqual(board.getBoardTeam().getName(), "NombreNewTeam");
        }

        [TestMethod]
        public void BoardGetDescriptionTest()
        {
            List<BoardElement> boardElements = new List<BoardElement>();
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide, boardElements);
            Assert.AreEqual(board.getDescription(), "BoardDescripcion");
        }

        [TestMethod]
        public void BoardSetDescriptionTest()
        {
            List<BoardElement> boardElements = new List<BoardElement>();
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide, boardElements);
            board.setDescripcion("BoardDescripcionCambiada");
            Assert.AreEqual(board.getDescription(), "BoardDescripcionCambiada");
        }

        [TestMethod]
        public void BoardGetHeightTest()
        {
            List<BoardElement> boardElements = new List<BoardElement>();
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide, boardElements);
            Assert.AreEqual(board.getHeight(), 10);
        }

        [TestMethod]
        public void BoardSetHeightTest()
        {
            List<BoardElement> boardElements = new List<BoardElement>();
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide, boardElements);
            board.setHeight(6);
            Assert.AreEqual(board.getHeight(), 6);
        }

        [TestMethod]
        public void BoardGetWideTest()
        {
            List<BoardElement> boardElements = new List<BoardElement>();
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide, boardElements);
            Assert.AreEqual(board.getWide(), 10);
        }

        [TestMethod]
        public void BoardSetWideTest()
        {
            List<BoardElement> boardElements = new List<BoardElement>();
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide, boardElements);
            board.setWide(5);
            Assert.AreEqual(board.getWide(), 5);
        }

        [TestMethod]
        public void BoardGetBoardElementsTest()
        {
            List<BoardElement> boardElements = new List<BoardElement>();
            DateTime dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            int maxUserCount = 1;
            List<User> teamUsers = new List<User>();
            Team boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            int height = 10;
            int wide = 10;
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, wide, boardElements);
            Assert.AreEqual(board.getBoardElements().Count, 0);
        }

    }
}
