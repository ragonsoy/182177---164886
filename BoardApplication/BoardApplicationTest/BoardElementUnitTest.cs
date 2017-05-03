using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;
using System.Collections.Generic;

namespace BoardApplicationTest
{
    [TestClass]
    public class BoardElementUnitTest
    {
        List<Commentary> comentarysBoardElement;
        int originPointX;
        int originPointY;
        int height;
        int width;
        DateTime creationDateTime;
        DateTime birthDate;
        User creatorUser;
        Commentary commentary;


        [TestInitialize]
        public void Init()
        {
            comentarysBoardElement = new List<Commentary>();
            originPointX = 10;
            originPointY = 9;
            height = 8;
            width = 7;
            creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            creatorUser = new User("NombreCreator", "Apellido", "Email", birthDate, "Password");
            commentary = new Commentary(creationDateTime, creatorUser, "Comentario");

        }

        [TestMethod]
        public void BoardElementGetOriginPointXTest()
        {
            BoardElement element = new BoardElement(originPointX, originPointY, height, width, comentarysBoardElement);
            Assert.AreEqual(element.getGetOriginPointX(), originPointX);
        }

        [TestMethod]
        public void BoardElementSetOriginPointXTest()
        {
            BoardElement element = new BoardElement(originPointX, originPointY, height, width, comentarysBoardElement);
            int newOriginPointX = 5;
            element.SetOriginPointX(newOriginPointX);
            Assert.AreEqual(element.getGetOriginPointX(), newOriginPointX);
        }

        [TestMethod]
        public void BoardElementGetOriginPointYTest()
        {
            BoardElement element = new BoardElement(originPointX, originPointY, height, width, comentarysBoardElement);
            Assert.AreEqual(element.getGetOriginPointY(), originPointY);
        }

        [TestMethod]
        public void BoardElementSetOriginPointYTest()
        {
            BoardElement element = new BoardElement(originPointX, originPointY, height, width, comentarysBoardElement);
            int newOriginPointY = 5;
            element.SetOriginPointY(newOriginPointY);
            Assert.AreEqual(element.getGetOriginPointY(), newOriginPointY);
        }

        [TestMethod]
        public void BoardElementGetHeightTest()
        {
            BoardElement element = new BoardElement(originPointX, originPointY, height, width, comentarysBoardElement);
            Assert.AreEqual(element.getGetHeigh(), height);
        }

        [TestMethod]
        public void BoardElementSetHeighTest()
        {
            BoardElement element = new BoardElement(originPointX, originPointY, height, width, comentarysBoardElement);
            int newHeight = 5;
            element.SetHeigh(newHeight);
            Assert.AreEqual(element.getGetHeigh(), newHeight);
        }

        [TestMethod]
        public void BoardElementGetWidthTest()
        {
            BoardElement element = new BoardElement(originPointX, originPointY, height, width, comentarysBoardElement);
            Assert.AreEqual(element.getGetWidth(), width);
        }

        [TestMethod]
        public void BoardElementSetWidthTest()
        {
            BoardElement element = new BoardElement(originPointX, originPointY, height, width, comentarysBoardElement);
            int newwidth = 5;
            element.SetWidth(newwidth);
            Assert.AreEqual(element.getGetWidth(), newwidth);
        }

        [TestMethod]
        public void BoardElementGetComentarysTest()
        {
            BoardElement element = new BoardElement(originPointX, originPointY, height, width, comentarysBoardElement);
            Assert.AreEqual(element.getComentarys().Count, 0);
        }

        [TestMethod]
        public void BoardElementAddComentaryTest()
        {
            BoardElement element = new BoardElement(originPointX, originPointY, height, width, comentarysBoardElement);
            element.AddCommentary(commentary);
            Assert.IsTrue(comentarysBoardElement.Contains(commentary));
        }


    }
}
