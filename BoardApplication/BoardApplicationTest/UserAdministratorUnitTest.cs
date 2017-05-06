using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;
using System.Collections.Generic;

namespace BoardApplicationTest
{
    [TestClass]
    public class UserAdministratorUnitTest
    {
        DateTime birthDateUser;
        string nameUser;
        string lastNameUser;
        string emailUser;
        string passwordUser;
        List<Team> teamsUser;
        List<Team> teamsAdministrator;

        [TestInitialize]
        public void Init()
        {
            dataForUserAdministratorTest();
        }

        public void dataForUserAdministratorTest()
        {
            birthDateUser = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDateUser);
            nameUser = "Nombre";
            lastNameUser = "Apellido";
            emailUser = "Email";
            passwordUser = "Password";
            teamsUser = new List<Team>();
            teamsAdministrator = new List<Team>();
        }


        [TestMethod]
        public void UserAdministratorGetNameTest()
        {
            User userAdministrator = new UserAdministrator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser, teamsAdministrator);
            Assert.AreEqual(userAdministrator.getName(), nameUser);
        }
        
        [TestMethod]
        public void UserAdministratorSetNameTest()
        {
            User userAdministrator = new UserAdministrator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser, teamsAdministrator);
            string changeNameUser = "NombreCambiado";
            userAdministrator.setName(changeNameUser);
            Assert.AreEqual(userAdministrator.getName(), changeNameUser);
        }

        [TestMethod]
        public void UserAdministratorGetLastNameTest()
        {
            User userAdministrator = new UserAdministrator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser, teamsAdministrator);
            Assert.AreEqual(userAdministrator.getLastName(), lastNameUser);
        }

        [TestMethod]
        public void UserAdministratorSetLastNameTest()
        {
            User userAdministrator = new UserAdministrator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser, teamsAdministrator);
            string changeLastNameUser = "ApellidoCambiado";
            userAdministrator.setLastName(changeLastNameUser);
            Assert.AreEqual(userAdministrator.getLastName(), changeLastNameUser);
        }

        [TestMethod]
        public void UserAdministratorGetEmailTest()
        {
            User userAdministrator = new UserAdministrator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser, teamsAdministrator);
            Assert.AreEqual(userAdministrator.getEmail(), emailUser);
        }

        [TestMethod]
        public void UserAdministratorSetEmailTest()
        {
            User userAdministrator = new UserAdministrator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser, teamsAdministrator);
            string changeEmailUser = "EmailCambiado";
            userAdministrator.setEmail(changeEmailUser);
            Assert.AreEqual(userAdministrator.getEmail(), changeEmailUser);
        }

        [TestMethod]
        public void UserAdministratorGetBirthDateTest()
        {
            User userAdministrator = new UserAdministrator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser, teamsAdministrator);
            Assert.AreEqual(userAdministrator.getBirthDate(), birthDateUser);
        }

        [TestMethod]
        public void UserAdministratorSetBirthDateTest()
        {
            DateTime birthDateAcambiar = new DateTime();
            DateTime.TryParse("2/2/2000", out birthDateAcambiar);
            User userAdministrator = new UserAdministrator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser, teamsAdministrator);
            userAdministrator.setBirthDate(birthDateAcambiar);
            Assert.AreEqual(userAdministrator.getBirthDate(), birthDateAcambiar);
        }

        [TestMethod]
        public void UserAdministratorGetPasswordTest()
        {
            User userAdministrator = new UserAdministrator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser, teamsAdministrator);
            Assert.AreEqual(userAdministrator.getPassword(), passwordUser);
        }

        [TestMethod]
        public void UserAdministratorSetPassword()
        {
            User userAdministrator = new UserAdministrator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser, teamsAdministrator);
            string changePasswordUserAdministration = "PasswordCambiado";
            userAdministrator.setPassword(changePasswordUserAdministration);
            Assert.AreEqual(userAdministrator.getPassword(), changePasswordUserAdministration);
        }

        [TestMethod]
        public void UserAdministratorChangePasswordTest()
        {
            User user = new User(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser, teamsUser);
            UserAdministrator userAdministrator = new UserAdministrator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser, teamsAdministrator);
            string changePasswordUser = "PasswordCambiado";
            userAdministrator.ChangePassword(user, changePasswordUser);
            Assert.AreEqual(user.getPassword(), changePasswordUser);
        }

        [TestMethod]
        public void UserAdministratorChangePasswordDefaultTest()
        {
            User user = new User(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser, teamsUser);
            UserAdministrator userAdministrator = new UserAdministrator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser, teamsAdministrator);
            userAdministrator.ChangePassword(user, nameUser);
            Assert.AreEqual(user.getPassword(), nameUser);
        }

        [TestMethod]
        public void UserAdministratorAddUserToTeamTest()
        {
            string nameTeam = "Equipo";
            DateTime dateCreationTeam = new DateTime();
            string description = "Descripcion";
            int maxUserCount = 1;
            List<Board> teamBoards = new List<Board>();
            Team team = new Team(nameTeam, dateCreationTeam, description, maxUserCount, teamBoards);
            User user = new User(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser, teamsUser);
            UserAdministrator userAdministrator = new UserAdministrator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser, teamsAdministrator);
            userAdministrator.AddUserToTeamTest(user, team);
            Assert.IsTrue(user.UserIsOnTeam(team));
        }
    }
}
