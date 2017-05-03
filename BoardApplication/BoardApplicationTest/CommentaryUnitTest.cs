using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;
using System.Collections.Generic;

namespace BoardApplicationTest
{
    
    [TestClass]
    public class CommentaryUnitTest
    {

        [TestMethod]
        public void CommentaryGetCreationDateTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            User resolutionUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            Commentary commentary = new Commentary(creationDateTime, resolutionDateTime, creatorUser, resolutionUser, "Comentario");
            Assert.AreEqual(commentary.getCreationDate(), creationDateTime);
        }

        [TestMethod]
        public void CommentarySetCreationDateTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            User resolutionUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            Commentary commentary = new Commentary(creationDateTime, resolutionDateTime, creatorUser, resolutionUser, "Comentario");
            DateTime creationDateTimeNew = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTimeNew);
            commentary.setCreationDate(creationDateTimeNew);
            Assert.AreEqual(commentary.getCreationDate(), creationDateTimeNew);
        }

        [TestMethod]
        public void CommentaryGetResolutionDateTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            User resolutionUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            Commentary commentary = new Commentary(creationDateTime, resolutionDateTime, creatorUser, resolutionUser, "Comentario");
            Assert.AreEqual(commentary.getResolutionDate(), resolutionDateTime);
        }

        [TestMethod]
        public void CommentarySetResolutionDateTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            User resolutionUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            Commentary commentary = new Commentary(creationDateTime, resolutionDateTime, creatorUser, resolutionUser, "Comentario");
            DateTime resolutionDateTimeNew = new DateTime();
            DateTime.TryParse("2/2/2000", out resolutionDateTimeNew);
            commentary.setResolutionDate(resolutionDateTimeNew);
            Assert.AreEqual(commentary.getResolutionDate(), resolutionDateTimeNew);
        }

        [TestMethod]
        public void CommentaryGetCreatorUserTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            User resolutionUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            Commentary commentary = new Commentary(creationDateTime, resolutionDateTime, creatorUser, resolutionUser, "Comentario");
            Assert.AreEqual(commentary.getCreatorUser().getName(), "Nombre");
        }

        [TestMethod]
        public void CommentarySetCreatorUserTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            User resolutionUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            Commentary commentary = new Commentary(creationDateTime, resolutionDateTime, creatorUser, resolutionUser, "Comentario");
            User creatorUserNew = new User("NombreNew", "ApellidoNew", "EmailNew", birthDate, "PasswordNew");
            commentary.setCreatorUser(creatorUserNew);
            Assert.AreEqual(commentary.getCreatorUser(), creatorUserNew);
        }

        [TestMethod]
        public void CommentaryGetResolutionUserTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("NombreCreator", "Apellido", "Email", birthDate, "Password");
            User resolutionUser = new User("NombreResolutor", "Apellido", "Email", birthDate, "Password");
            Commentary commentary = new Commentary(creationDateTime, resolutionDateTime, creatorUser, resolutionUser, "Comentario");
            Assert.AreEqual(commentary.getResolutionUser().getName(), "NombreResolutor");
        }

        [TestMethod]
        public void CommentarySetResolutionUserTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("NombreCreator", "Apellido", "Email", birthDate, "Password");
            User resolutionUser = new User("NombreResolutor", "Apellido", "Email", birthDate, "Password");
            Commentary commentary = new Commentary(creationDateTime, resolutionDateTime, creatorUser, resolutionUser, "Comentario");
            User resolutionUserNew = new User("NombreResolutorNew", "ApellidoNew", "EmailNew", birthDate, "PasswordNew");
            commentary.setResolutionUser(resolutionUserNew);
            Assert.AreEqual(commentary.getResolutionUser().getName(), "NombreResolutorNew");
        }

        [TestMethod]
        public void CommentaryGetCommentaryTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("NombreCreator", "Apellido", "Email", birthDate, "Password");
            User resolutionUser = new User("NombreResolutor", "Apellido", "Email", birthDate, "Password");
            Commentary commentary = new Commentary(creationDateTime, resolutionDateTime, creatorUser, resolutionUser, "Comentario");
            Assert.AreEqual(commentary.getCommentary(), "Comentario");
        }

        [TestMethod]
        public void CommentarySetCommentaryTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("NombreCreator", "Apellido", "Email", birthDate, "Password");
            User resolutionUser = new User("NombreResolutor", "Apellido", "Email", birthDate, "Password");
            Commentary commentary = new Commentary(creationDateTime, resolutionDateTime, creatorUser, resolutionUser, "Comentario");
            commentary.SetCommentary("NewComentario");
            Assert.AreEqual(commentary.getCommentary(), "NewComentario");
        }

    }
}
