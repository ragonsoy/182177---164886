using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;
using System.Collections.Generic;

namespace BoardApplicationTest
{
    
    [TestClass]
    public class CommentaryUnitTest
    {
        [TestInitialize]
        public void Init()
        {
            
        }

        [TestMethod]
        public void CommentaryGetCreationDateTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");            
            Commentary commentary = new Commentary(creationDateTime, creatorUser, "Comentario");
            Assert.AreEqual(commentary.getCreationDate(), creationDateTime);
        }

        [TestMethod]
        public void CommentarySetCreationDateTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            Commentary commentary = new Commentary(creationDateTime, creatorUser, "Comentario");
            DateTime creationDateTimeNew = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTimeNew);
            commentary.setCreationDate(creationDateTimeNew);
            Assert.AreEqual(commentary.getCreationDate(), creationDateTimeNew);
        }        

        [TestMethod]
        public void CommentaryGetCreatorUserTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            Commentary commentary = new Commentary(creationDateTime, creatorUser, "Comentario");
            Assert.AreEqual(commentary.getCreatorUser().getName(), "Nombre");
        }

        [TestMethod]
        public void CommentarySetCreatorUserTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            Commentary commentary = new Commentary(creationDateTime, creatorUser, "Comentario");
            User creatorUserNew = new User("NombreNew", "ApellidoNew", "EmailNew", birthDate, "PasswordNew");
            commentary.setCreatorUser(creatorUserNew);
            Assert.AreEqual(commentary.getCreatorUser(), creatorUserNew);
        }

        

        [TestMethod]
        public void CommentaryGetCommentaryTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("NombreCreator", "Apellido", "Email", birthDate, "Password");
            Commentary commentary = new Commentary(creationDateTime, creatorUser, "Comentario");
            Assert.AreEqual(commentary.getCommentary(), "Comentario");
        }

        [TestMethod]
        public void CommentarySetCommentaryTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User creatorUser = new User("NombreCreator", "Apellido", "Email", birthDate, "Password");
            Commentary commentary = new Commentary(creationDateTime, creatorUser, "Comentario");
            commentary.SetCommentary("NewComentario");
            Assert.AreEqual(commentary.getCommentary(), "NewComentario");
        }

    }
}
