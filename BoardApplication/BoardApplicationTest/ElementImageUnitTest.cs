﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;
using System.Collections.Generic;

namespace BoardApplicationTest
{
    [TestClass]
    public class ElementImageUnitTest
    {
        List<Commentary> comentarysBoardElement;
        int originPointX;
        int originPointY;
        int height;
        int width;
        DateTime creationDateTime;
        List<Team> teamsUser;
        DateTime birthDate;
        User creatorUser;
        Commentary commentary;
        string url;

        [TestInitialize]
        public void Init()
        {
            dataForElementImageTest();            
            dataForCommentaryTest();
        }

        public void dataForElementImageTest()
        {
            url = "c:/dia/x";
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
        public void ElementImageGetUrlTest()
        {
            ElementImage element = new ElementImage(url, originPointX, originPointY, height, width, comentarysBoardElement);
            Assert.AreEqual(element.getUrl(), url);
        }

        [TestMethod]
        public void ElementImageSetUrlTest()
        {
            ElementImage element = new ElementImage(url, originPointX, originPointY, height, width, comentarysBoardElement);
            string newUrl = "d:/mis documentos";
            element.setUrl(newUrl);
            Assert.AreEqual(element.getUrl(), newUrl);
        }
    }
}
