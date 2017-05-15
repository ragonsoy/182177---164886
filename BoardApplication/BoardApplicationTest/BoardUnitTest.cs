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
        int height;
        int width;
        List<Commentary> comentarysElement;
        int originPointX;
        int originPointY;
        int heightElement;
        int widthElement;
        BoardElement element;
        DateTime birthDateUser;
        string nameUser;
        string lastNameUser;
        string emailUser;
        string passwordUser;
        List<Team> teamsUser;
        UserCollaborator creatorUser;
        Board board;
        Board boardPrueba;

        [TestInitialize]
        public void Init()
        {
            dataForUserTest();
            dataForBoardTest();
            dataForBoardElementTest();
            
        }

        public void dataForBoardTest()
        {
            boardElements = new List<BoardElement>();
            height = 10;
            width = 10;
            board = new Board("NombreBoard", "BoardDescripcion", height, width, creatorUser);
            boardPrueba = new Board("NombreBoard", "BoardDescripcion", height, width, creatorUser);
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

        public void dataForUserTest()
        {
            birthDateUser = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDateUser);
            nameUser = "Nombre";
            lastNameUser = "Apellido";
            emailUser = "Email";
            passwordUser = "Password";
            teamsUser = new List<Team>();
            creatorUser = new UserCollaborator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser);
        }

        [TestMethod]
        public void BoardGetNameTest()
        {
            Assert.AreEqual(board.getName(), "NombreBoard");
        }

        [TestMethod]
        public void BoardSetNameTest()
        {
            board.setName("NombreCambiado");
            Assert.AreEqual(board.getName(), "NombreCambiado");
        }
        
        [TestMethod]
        public void BoardGetDescriptionTest()
        {
            Assert.AreEqual(board.getDescription(), "BoardDescripcion");
        }

        [TestMethod]
        public void BoardSetDescriptionTest()
        {
            board.setDescripcion("BoardDescripcionCambiada");
            Assert.AreEqual(board.getDescription(), "BoardDescripcionCambiada");
        }

        [TestMethod]
        public void BoardGetHeightTest()
        {
            Assert.AreEqual(board.getHeight(), height);
        }

        [TestMethod]
        public void BoardSetHeightTest()
        {
            board.setHeight(6);
            Assert.AreEqual(board.getHeight(), 6);
        }

        [TestMethod]
        public void BoardGetWidthTest()
        {
            Assert.AreEqual(board.getWidth(), width);
        }

        [TestMethod]
        public void BoardSetWidthTest()
        {
            board.setWidth(5);
            Assert.AreEqual(board.getWidth(), 5);
        }

        [TestMethod]
        public void BoardGetBoardElementsTest()
        {
            Assert.AreEqual(board.getBoardElements().Count, 0);
        }

        [TestMethod]
        public void BoardAddBoardElementTest()
        {
            board.AddBoardElements(element);
            Assert.IsTrue(board.getBoardElements().Contains(element));
        }

        [TestMethod]
        public void BoardRemoveBoardElementTest()
        {
            board.AddBoardElements(element);
            board.RemoveBoardElements(element);
            Assert.IsFalse(board.getBoardElements().Contains(element));
        }

        [TestMethod]
        public void BoardRemoveBoardElementNotExistTest()
        {
            board.RemoveBoardElements(element);
            Assert.IsFalse(board.getBoardElements().Contains(element));
        }

        [TestMethod]
        public void ToStringBoardElementTest()
        {
            Assert.AreEqual(board.ToString(), "NombreBoard");
        }

        [TestMethod]
        public void EqualsBoardElementTest()
        {            
            Assert.IsTrue(board.Equals(boardPrueba));
        }
        
        [TestMethod]
        public void IsUserCreatorBoardElementTest()
        {
            Assert.IsTrue(board.IsUserCreator(creatorUser));
        }
    }


}
