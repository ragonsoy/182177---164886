using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;
using System.Collections.Generic;

namespace BoardApplicationTest
{
    [TestClass]
    public class ElementTextUnitTest
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
        string text;
        int fontSize;
        string font;

        [TestInitialize]
        public void Init()
        {
            text = "oneText";
            fontSize = 11;
            font = "Arial";
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
        public void ElementImageGetTextTest()
        {
            ElementText element = new ElementText(text, fontSize, font, originPointX, originPointY, height, width, comentarysBoardElement);
            Assert.AreEqual(element.GetText(), text);
        }

        [TestMethod]
        public void ElementImageSetTextTest()
        {
            ElementText element = new ElementText(text, fontSize, font, originPointX, originPointY, height, width, comentarysBoardElement);
            string newText = "twoText";
            element.SetText(newText);
            Assert.AreEqual(element.GetText(), newText);
        }

        [TestMethod]
        public void ElementImageGetFontSizeTest()
        {
            ElementText element = new ElementText(text, fontSize, font, originPointX, originPointY, height, width, comentarysBoardElement);
            Assert.AreEqual(element.GetFontSize(), fontSize);
        }

        [TestMethod]
        public void ElementImageSetFontSizeTest()
        {
            ElementText element = new ElementText(text, fontSize, font, originPointX, originPointY, height, width, comentarysBoardElement);
            int newFontSize = 12;
            element.SetFontSize(newFontSize);
            Assert.AreEqual(element.GetFontSize(), newFontSize);
        }

        [TestMethod]
        public void ElementImageGetFontTest()
        {
            ElementText element = new ElementText(text, fontSize, font, originPointX, originPointY, height, width, comentarysBoardElement);
            Assert.AreEqual(element.GetFont(), font);
        }

        [TestMethod]
        public void ElementImageSetFontTest()
        {
            ElementText element = new ElementText(text, fontSize, font, originPointX, originPointY, height, width, comentarysBoardElement);
            string newFont = "TimesNewRoman";
            element.SetFont(newFont);
            Assert.AreEqual(element.GetFont(), newFont);
        }
    }
}
