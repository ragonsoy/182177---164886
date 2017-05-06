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
        List<Team> teamsUser;
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
            dataForElementTextTest();
            dataForCommentaryTest();
        }

        public void dataForElementTextTest()
        {
            text = "oneText";
            fontSize = 11;
            font = "Arial";
            comentarysBoardElement = new List<Commentary>();
            originPointX = 10;
            originPointY = 9;
            height = 8;
            width = 7;
        }

        public void dataForUserTest()
        {
            birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            teamsUser = new List<Team>();
            creatorUser = new User("NombreCreator", "Apellido", "Email", birthDate, "Password", teamsUser);
        }

        public void dataForCommentaryTest()
        {
            dataForUserTest();
            creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);            
            commentary = new Commentary(creationDateTime, creatorUser, "Comentario");
        }

        [TestMethod]
        public void ElementImageGetTextTest()
        {
            ElementText element = new ElementText(text, fontSize, font, originPointX, originPointY, height, width, comentarysBoardElement);
            Assert.AreEqual(element.getText(), text);
        }

        [TestMethod]
        public void ElementImageSetTextTest()
        {
            ElementText element = new ElementText(text, fontSize, font, originPointX, originPointY, height, width, comentarysBoardElement);
            string newText = "twoText";
            element.setText(newText);
            Assert.AreEqual(element.getText(), newText);
        }

        [TestMethod]
        public void ElementImageGetFontSizeTest()
        {
            ElementText element = new ElementText(text, fontSize, font, originPointX, originPointY, height, width, comentarysBoardElement);
            Assert.AreEqual(element.getFontSize(), fontSize);
        }

        [TestMethod]
        public void ElementImageSetFontSizeTest()
        {
            ElementText element = new ElementText(text, fontSize, font, originPointX, originPointY, height, width, comentarysBoardElement);
            int newFontSize = 12;
            element.setFontSize(newFontSize);
            Assert.AreEqual(element.getFontSize(), newFontSize);
        }

        [TestMethod]
        public void ElementImageGetFontTest()
        {
            ElementText element = new ElementText(text, fontSize, font, originPointX, originPointY, height, width, comentarysBoardElement);
            Assert.AreEqual(element.getFont(), font);
        }

        [TestMethod]
        public void ElementImageSetFontTest()
        {
            ElementText element = new ElementText(text, fontSize, font, originPointX, originPointY, height, width, comentarysBoardElement);
            string newFont = "TimesNewRoman";
            element.setFont(newFont);
            Assert.AreEqual(element.getFont(), newFont);
        }
    }
}
