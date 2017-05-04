using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;
using System.Collections.Generic;

namespace BoardApplicationTest
{

    [TestClass]
    public class BoardUnitTest
    {
        List<BoardElement> boardElements;
        DateTime dateTime;
        int maxUserCount;
        List<User> teamUsers;
        Team boardTeam;
        int height;
        int width;
        Team boardNewTeam;
        List<Commentary> comentarysElement;
        int originPointX;
        int originPointY;
        int heightElement;
        int widthElement;
        BoardElement element;

        [TestInitialize]
        public void Init()
        {
            dataForBoardTest();
            dataForTeamTest();
            dataForBoardElementTest();
        }

        public void dataForBoardTest()
        {
            boardElements = new List<BoardElement>();
            height = 10;
            width = 10;
        }

        public void dataForTeamTest()
        {
            dateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out dateTime);
            maxUserCount = 1;
            teamUsers = new List<User>();
            boardTeam = new Team("NombreTeam", dateTime, "Descripcion", maxUserCount, teamUsers);
            boardNewTeam = new Team("NombreNewTeam", dateTime, "Descripcion", maxUserCount, teamUsers);               
        }

        public void dataForBoardElementTest()
        {
            comentarysElement = new List<Commentary>();
            originPointX = 10;
            originPointY = 9;
            heightElement = 8;
            widthElement = 7;
            element = new BoardElement(originPointX, originPointY, heightElement, widthElement, comentarysElement);
        }

        [TestMethod]
        public void BoardGetNameTest()
        {
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, width, boardElements);
            Assert.AreEqual(board.getName(), "NombreBoard");
        }

        [TestMethod]
        public void BoardSetNameTest()
        {
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, width, boardElements);
            board.setName("NombreCambiado");
            Assert.AreEqual(board.getName(), "NombreCambiado");
        }

        [TestMethod]
        public void BoardGetBoardTeamTest()
        {
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, width, boardElements);
            Assert.AreEqual(board.getBoardTeam().getName(), "NombreTeam");
        }

        [TestMethod]
        public void BoardSetBoardTeamTest()
        {
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, width, boardElements);
            board.SetBoardTeam(boardNewTeam);
            Assert.AreEqual(board.getBoardTeam().getName(), "NombreNewTeam");
        }

        [TestMethod]
        public void BoardGetDescriptionTest()
        {
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, width, boardElements);
            Assert.AreEqual(board.getDescription(), "BoardDescripcion");
        }

        [TestMethod]
        public void BoardSetDescriptionTest()
        {
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, width, boardElements);
            board.setDescripcion("BoardDescripcionCambiada");
            Assert.AreEqual(board.getDescription(), "BoardDescripcionCambiada");
        }

        [TestMethod]
        public void BoardGetHeightTest()
        {
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, width, boardElements);
            Assert.AreEqual(board.getHeight(), height);
        }

        [TestMethod]
        public void BoardSetHeightTest()
        {
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, width, boardElements);
            board.setHeight(6);
            Assert.AreEqual(board.getHeight(), 6);
        }

        [TestMethod]
        public void BoardGetWidthTest()
        {
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, width, boardElements);
            Assert.AreEqual(board.getWidth(), width);
        }

        [TestMethod]
        public void BoardSetWidthTest()
        {
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, width, boardElements);
            board.setWidth(5);
            Assert.AreEqual(board.getWidth(), 5);
        }

        [TestMethod]
        public void BoardGetBoardElementsTest()
        {
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, width, boardElements);
            Assert.AreEqual(board.getBoardElements().Count, 0);
        }

        [TestMethod]
        public void BoardAddBoardElementTest()
        {
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, width, boardElements);
            board.AddBoardElements(element);
            Assert.IsTrue(board.getBoardElements().Contains(element));
        }

        [TestMethod]
        public void BoardRemoveBoardElementTest()
        {
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, width, boardElements);
            board.AddBoardElements(element);
            board.RemoveBoardElements(element);
            Assert.IsFalse(board.getBoardElements().Contains(element));
        }

        [TestMethod]
        public void BoardRemoveBoardElementNotExistTest()
        {
            Board board = new Board("NombreBoard", boardTeam, "BoardDescripcion", height, width, boardElements);
            board.RemoveBoardElements(element);
            Assert.IsFalse(board.getBoardElements().Contains(element));
        }
        
    }
}
