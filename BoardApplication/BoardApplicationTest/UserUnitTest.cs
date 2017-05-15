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
        User user;
        DateTime dateCreationTeam;
        int maxUserCount;
        List<Board> teamBoards;
        string nameTeam;
        string description;
        Team teamTestOne;
        Team teamTestTwo;

        [TestInitialize]
        public void Init()
        {
            dataForTeamTest();
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
            user = new UserAdministrator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser);
        }

        public void dataForTeamTest()
        {
            nameTeam = "NombreOne";
            description = "Descripcion";
            dateCreationTeam = new DateTime();
            DateTime.TryParse("1/1/2000", out dateCreationTeam);
            maxUserCount = 2;
            teamBoards = new List<Board>();
            teamTestOne = new Team(nameTeam, dateCreationTeam, description, maxUserCount);
            teamTestTwo = new Team("NombreTwo", dateCreationTeam, description, maxUserCount);
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

        [TestMethod]
        public void UserEqualsTest()
        {
            Assert.IsTrue(user.Equals(user));
        }

        [TestMethod]
        public void UserPasswordCorrectTest()
        {
            Assert.IsTrue(user.PasswordCorrect(passwordUser));
        }

        [TestMethod]
        public void UserGetTeamsTest()
        {
            Assert.AreEqual(user.getTeams().Count, 0);
        }

        [TestMethod]
        public void UserAddToTeamTest()
        {
            user.AddToTeam(teamTestTwo);
            Assert.IsTrue(user.getTeams().Contains(teamTestTwo));
        }
    }
}
