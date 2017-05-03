using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;
using System.Collections.Generic;

namespace BoardApplicationTest
{
    [TestClass]
    public class EndCommentaryUnitTest
    {
        [TestMethod]
        public void EndCommentaryGetResolutionDateTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            User resolutionUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            EndCommentary commentary = new EndCommentary(creationDateTime, resolutionDateTime, creatorUser, resolutionUser, "Comentario");
            Assert.AreEqual(commentary.getResolutionDate(), resolutionDateTime);
        }

        [TestMethod]
        public void EndCommentarySetResolutionDateTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            User resolutionUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            EndCommentary commentary = new EndCommentary(creationDateTime, resolutionDateTime, creatorUser, resolutionUser, "Comentario");
            DateTime resolutionDateTimeNew = new DateTime();
            DateTime.TryParse("2/2/2000", out resolutionDateTimeNew);
            commentary.setResolutionDate(resolutionDateTimeNew);
            Assert.AreEqual(commentary.getResolutionDate(), resolutionDateTimeNew);
        }
        [TestMethod]
        public void EndCommentaryGetResolutionUserTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("NombreCreator", "Apellido", "Email", birthDate, "Password");
            User resolutionUser = new User("NombreResolutor", "Apellido", "Email", birthDate, "Password");
            EndCommentary commentary = new EndCommentary(creationDateTime, resolutionDateTime, creatorUser, resolutionUser, "Comentario");
            Assert.AreEqual(commentary.getResolutionUser().getName(), "NombreResolutor");
        }

        [TestMethod]
        public void EndCommentarySetResolutionUserTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("NombreCreator", "Apellido", "Email", birthDate, "Password");
            User resolutionUser = new User("NombreResolutor", "Apellido", "Email", birthDate, "Password");
            EndCommentary commentary = new EndCommentary(creationDateTime, resolutionDateTime, creatorUser, resolutionUser, "Comentario");
            User resolutionUserNew = new User("NombreResolutorNew", "ApellidoNew", "EmailNew", birthDate, "PasswordNew");
            commentary.setResolutionUser(resolutionUserNew);
            Assert.AreEqual(commentary.getResolutionUser().getName(), "NombreResolutorNew");
        }
    }
}
