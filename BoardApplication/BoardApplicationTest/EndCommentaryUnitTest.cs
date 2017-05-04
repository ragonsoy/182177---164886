using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;
using System.Collections.Generic;

namespace BoardApplicationTest
{
    [TestClass]
    public class EndCommentaryUnitTest
    {
        DateTime creationDateTime;
        DateTime resolutionDateTime;
        DateTime birthDate;
        User creatorUser;
        User resolutionUser;

        [TestInitialize]
        public void Init()
        {
            creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            creatorUser = new User("NombreCreator", "Apellido", "Email", birthDate, "Password");
            resolutionUser = new User("NombreResolutor", "Apellido", "Email", birthDate, "Password");
        }

        [TestMethod]
        public void EndCommentaryGetResolutionDateTest()
        {
           
            EndCommentary commentary = new EndCommentary(creationDateTime, resolutionDateTime, creatorUser, resolutionUser, "Comentario");
            Assert.AreEqual(commentary.getResolutionDate(), resolutionDateTime);
        }

        [TestMethod]
        public void EndCommentarySetResolutionDateTest()
        {EndCommentary commentary = new EndCommentary(creationDateTime, resolutionDateTime, creatorUser, resolutionUser, "Comentario");
            DateTime resolutionDateTimeNew = new DateTime();
            DateTime.TryParse("2/2/2000", out resolutionDateTimeNew);
            commentary.setResolutionDate(resolutionDateTimeNew);
            Assert.AreEqual(commentary.getResolutionDate(), resolutionDateTimeNew);
        }
        [TestMethod]
        public void EndCommentaryGetResolutionUserTest()
        {
            EndCommentary commentary = new EndCommentary(creationDateTime, resolutionDateTime, creatorUser, resolutionUser, "Comentario");
            Assert.AreEqual(commentary.getResolutionUser().getName(), "NombreResolutor");
        }

        [TestMethod]
        public void EndCommentarySetResolutionUserTest()
        {
            EndCommentary commentary = new EndCommentary(creationDateTime, resolutionDateTime, creatorUser, resolutionUser, "Comentario");
            User resolutionUserNew = new User("NombreResolutorNew", "ApellidoNew", "EmailNew", birthDate, "PasswordNew");
            commentary.setResolutionUser(resolutionUserNew);
            Assert.AreEqual(commentary.getResolutionUser().getName(), "NombreResolutorNew");
        }
    }
}
