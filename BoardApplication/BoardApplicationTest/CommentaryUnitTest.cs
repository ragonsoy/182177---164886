using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;
using System.Collections.Generic;

namespace BoardApplicationTest
{
    
    [TestClass]
    public class CommentaryUnitTest
    {
        List<Team> teamsUser;
        DateTime creationDateTime;
        DateTime birthDate;
        User creatorUser;

        [TestInitialize]
        public void Init()
        {
            dataForCommentaryTest();
            dataForUserTest();
        }

        public void dataForCommentaryTest()
        {
            creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
        }

        public void dataForUserTest()
        {
            birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            teamsUser = new List<Team>();
            creatorUser = new User("Nombre", "Apellido", "Email", birthDate, "Password", teamsUser);
        }

        [TestMethod]
        public void CommentaryGetCreationDateTest()
        {         
            Commentary commentary = new Commentary(creationDateTime, creatorUser, "Comentario");
            Assert.AreEqual(commentary.getCreationDate(), creationDateTime);
        }

        [TestMethod]
        public void CommentarySetCreationDateTest()
        {
            Commentary commentary = new Commentary(creationDateTime, creatorUser, "Comentario");
            DateTime creationDateTimeNew = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTimeNew);
            commentary.setCreationDate(creationDateTimeNew);
            Assert.AreEqual(commentary.getCreationDate(), creationDateTimeNew);
        }        

        [TestMethod]
        public void CommentaryGetCreatorUserTest()
        {
            User creatorUser = new User("Nombre", "Apellido", "Email", birthDate, "Password", teamsUser);
            Commentary commentary = new Commentary(creationDateTime, creatorUser, "Comentario");
            Assert.AreEqual(commentary.getCreatorUser().getName(), "Nombre");
        }

        [TestMethod]
        public void CommentarySetCreatorUserTest()
        {
            Commentary commentary = new Commentary(creationDateTime, creatorUser, "Comentario");
            User creatorUserNew = new User("NombreNew", "ApellidoNew", "EmailNew", birthDate, "PasswordNew", teamsUser);
            commentary.setCreatorUser(creatorUserNew);
            Assert.AreEqual(commentary.getCreatorUser(), creatorUserNew);
        }

        [TestMethod]
        public void CommentaryGetCommentaryTest()
        {
            Commentary commentary = new Commentary(creationDateTime, creatorUser, "Comentario");
            Assert.AreEqual(commentary.getCommentary(), "Comentario");
        }

        [TestMethod]
        public void CommentarySetCommentaryTest()
        {
            Commentary commentary = new Commentary(creationDateTime, creatorUser, "Comentario");
            commentary.SetCommentary("NewComentario");
            Assert.AreEqual(commentary.getCommentary(), "NewComentario");
        }

    }
}
