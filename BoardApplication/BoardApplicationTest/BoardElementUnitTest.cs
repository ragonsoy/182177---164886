using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;
using System.Collections.Generic;

namespace BoardApplicationTest
{
    [TestClass]
    public class BoardElementUnitTest
    {

        [TestMethod]
        public void BoardElementGetOriginPointXTest()
        {
            List<Commentary> comentarysBoardElement = new List<Commentary>();
            int originPointX = 10;
            int originPointY = 9;
            int height = 8;
            int wide = 7;
            BoardElement element = new BoardElement(originPointX, originPointY, height, wide, comentarysBoardElement);
            Assert.AreEqual(element.getGetOriginPointX(), originPointX);
        }

        [TestMethod]
        public void BoardElementSetOriginPointXTest()
        {
            List<Commentary> comentarysBoardElement = new List<Commentary>();
            int originPointX = 10;
            int originPointY = 9;
            int height = 8;
            int wide = 7;
            BoardElement element = new BoardElement(originPointX, originPointY, height, wide, comentarysBoardElement);
            int newOriginPointX = 5;
            element.SetOriginPointX(newOriginPointX);
            Assert.AreEqual(element.getGetOriginPointX(), newOriginPointX);
        }

        [TestMethod]
        public void BoardElementGetOriginPointYTest()
        {
            List<Commentary> comentarysBoardElement = new List<Commentary>();
            int originPointX = 10;
            int originPointY = 9;
            int height = 8;
            int wide = 7;
            BoardElement element = new BoardElement(originPointX, originPointY, height, wide, comentarysBoardElement);
            Assert.AreEqual(element.getGetOriginPointY(), originPointY);
        }

        [TestMethod]
        public void BoardElementSetOriginPointYTest()
        {
            List<Commentary> comentarysBoardElement = new List<Commentary>();
            int originPointX = 10;
            int originPointY = 9;
            int height = 8;
            int wide = 7;
            BoardElement element = new BoardElement(originPointX, originPointY, height, wide, comentarysBoardElement);
            int newOriginPointY = 5;
            element.SetOriginPointY(newOriginPointY);
            Assert.AreEqual(element.getGetOriginPointY(), newOriginPointY);
        }

        [TestMethod]
        public void BoardElementGetHeightTest()
        {
            List<Commentary> comentarysBoardElement = new List<Commentary>();
            int originPointX = 10;
            int originPointY = 9;
            int height = 8;
            int wide = 7;
            BoardElement element = new BoardElement(originPointX, originPointY, height, wide, comentarysBoardElement);
            Assert.AreEqual(element.getGetHeigh(), height);
        }

        [TestMethod]
        public void BoardElementSetHeighTest()
        {
            List<Commentary> comentarysBoardElement = new List<Commentary>();
            int originPointX = 10;
            int originPointY = 9;
            int height = 8;
            int wide = 7;
            BoardElement element = new BoardElement(originPointX, originPointY, height, wide, comentarysBoardElement);
            int newHeight = 5;
            element.SetHeigh(newHeight);
            Assert.AreEqual(element.getGetHeigh(), newHeight);
        }

        [TestMethod]
        public void BoardElementGetWideTest()
        {
            List<Commentary> comentarysBoardElement = new List<Commentary>();
            int originPointX = 10;
            int originPointY = 9;
            int height = 8;
            int wide = 7;
            BoardElement element = new BoardElement(originPointX, originPointY, height, wide, comentarysBoardElement);
            Assert.AreEqual(element.getGetWide(), wide);
        }

        [TestMethod]
        public void BoardElementSetWideTest()
        {
            List<Commentary> comentarysBoardElement = new List<Commentary>();
            int originPointX = 10;
            int originPointY = 9;
            int height = 8;
            int wide = 7;
            BoardElement element = new BoardElement(originPointX, originPointY, height, wide, comentarysBoardElement);
            int newWide = 5;
            element.SetWide(newWide);
            Assert.AreEqual(element.getGetWide(), newWide);
        }

        [TestMethod]
        public void BoardElementGetComentarysTest()
        {
            List<Commentary> comentarysBoardElement = new List<Commentary>();
            int originPointX = 10;
            int originPointY = 9;
            int height = 8;
            int wide = 7;
            BoardElement element = new BoardElement(originPointX, originPointY, height, wide, comentarysBoardElement);
            Assert.AreEqual(element.getComentarys().Count, 0);
        }

        [TestMethod]
        public void BoardElementAddComentaryTest()
        {
            List<Commentary> comentarysBoardElement = new List<Commentary>();
            int originPointX = 10;
            int originPointY = 9;
            int height = 8;
            int wide = 7;
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("NombreCreator", "Apellido", "Email", birthDate, "Password");
            User resolutionUser = new User("NombreResolutor", "Apellido", "Email", birthDate, "Password");
            Commentary commentary = new Commentary(creationDateTime, resolutionDateTime, creatorUser, resolutionUser, "Comentario");
            BoardElement element = new BoardElement(originPointX, originPointY, height, wide, comentarysBoardElement);
            element.AddCommentary(commentary);
            Assert.IsTrue(comentarysBoardElement.Contains(commentary));
        }


    }
}
