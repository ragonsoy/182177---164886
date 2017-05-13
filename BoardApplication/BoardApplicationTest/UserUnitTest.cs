using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;
using System.Collections.Generic;

namespace BoardApplicationTest
{
    [TestClass]
    public class UserUnitTest
    {
        DateTime birthDateUser;
        string nameUser;
        string lastNameUser;
        string emailUser;
        string passwordUser;
        List<Team> teamsUser;
        User user;

        [TestInitialize]
        public void Init()
        {
            dataForUserTest();
        }
        public void dataForUserTest()
        {
            birthDateUser = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDateUser);
            nameUser = "Nombre";
            lastNameUser = "Apellido";
            emailUser = "Email";
            passwordUser = "Password";
            teamsUser = new List<Team>();
            user = new UserAdministrator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser);
        }

        [TestMethod]
        public void UserGetNameTest()
        {            
            
            Assert.AreEqual(user.getName(), nameUser);
        }

        [TestMethod]
        public void UserSetNameTest()
        {
            string changeNameUser = "NombreCambiado";
            user.setName(changeNameUser);
            Assert.AreEqual(user.getName(), changeNameUser);
        }

        [TestMethod]
        public void UserGetLastNameTest()
        {
            Assert.AreEqual(user.getLastName(), lastNameUser);
        }

        [TestMethod]
        public void UserSetLastNameTest()
        {
            string changeLastNameUser = "ApellidoCambiado";
            user.setLastName(changeLastNameUser);
            Assert.AreEqual(user.getLastName(), changeLastNameUser);
        }

        [TestMethod]
        public void UserGetEmailTest()
        {
            Assert.AreEqual(user.getEmail(), emailUser);
        }

        [TestMethod]
        public void UserSetEmailTest()
        {
            string changeEmail = "EmailCambiado";
            user.setEmail(changeEmail);
            Assert.AreEqual(user.getEmail(), changeEmail);
        }

        [TestMethod]
        public void UserGetBirthDateTest()
        {
            Assert.AreEqual(user.getBirthDate(), birthDateUser);
        }

        [TestMethod]
        public void UserSetBirthDateTest()
        {
            DateTime changeBirthDate = new DateTime();
            DateTime.TryParse("2/2/2000", out changeBirthDate);
            user.setBirthDate(changeBirthDate);
            Assert.AreEqual(user.getBirthDate(), changeBirthDate);
        }

        [TestMethod]
        public void UserGetPasswordTest()
        {
            Assert.AreEqual(user.getPassword(), passwordUser);
        }

        [TestMethod]
        public void UserSetPasswordTest()
        {
            string changePassword = "PasswordCambiado";
            user.setPassword(changePassword);
            Assert.AreEqual(user.getPassword(), changePassword);
        }

        //[TestMethod]
        //public void UserCreationBoardTest()
        //{
        //    DateTime dateCreationTeam = new DateTime();
        //    DateTime.TryParse("1/1/2000", out dateCreationTeam);
        //    List<Board> teamBoards = new List<Board>();
        //    Team team = new Team("Nombre", dateCreationTeam, "Descripcion", 1, teamBoards);
        //    teamsUser.Add(team);
        //    User user = new User(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser, teamsUser);
        //    Assert.IsTrue(user.CreationBoard(team, "NombreBoard", "BoardDescripcion", 1, 1));
        //}

        //[TestMethod]
        //public void UserModifyBoardTest()
        //{
        //    DateTime dateCreationTeam = new DateTime();
        //    DateTime.TryParse("1/1/2000", out dateCreationTeam);
        //    List<Board> teamBoards = new List<Board>();
        //    Team team = new Team("Nombre", dateCreationTeam, "Descripcion", 1, teamBoards);
        //    teamsUser.Add(team);
        //    //List<BoardElement> boardElements = new List<BoardElement>();
        //    //Board board = new Board("NombreBoard", "BoardDescripcion", 1, 1, boardElements);
        //    User user = new User(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser, teamsUser);
        //    user.CreationBoard(team, "NombreBoard", "BoardDescripcion", 1);
        //    Assert.IsTrue(user.ModifyBoard(team, board));
        //}

    }
}
