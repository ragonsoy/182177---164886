using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;

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
        Size fontSize;
        Font font;

        [TestInitialize]
        public void Init()
        {
            dataForElementTextTest();
            dataForCommentaryTest();
        }

        public void dataForElementTextTest()
        {
            text = "oneText";
            fontSize = new Size(11,11);
            font = new Font("Times New Roman", 12.0f);
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
            creatorUser = new UserCollaborator("NombreCreator", "Apellido", "Email", birthDate, "Password");
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
            Size newFontSize = new Size(12,12);
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
            Font newFont = new Font("Cambria", 16.0f);
            element.setFont(newFont);
            Assert.AreEqual(element.getFont(), newFont);
        }
        
    }
}
