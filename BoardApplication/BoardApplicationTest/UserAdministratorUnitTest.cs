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
        User userAdministrator;
        string nameTeam;
        DateTime dateCreationTeam;
        string description;
        int maxUserCount;
        List<Board> teamBoards;
        Team team;

        [TestInitialize]
        public void Init()
        {
            dataForUserAdministratorTest();
            dataForTeamsAdministratorTest();
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
            userAdministrator = new UserAdministrator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser);
        }
        public void dataForTeamsAdministratorTest()
        {
        nameTeam = "Equipo";
        dateCreationTeam = new DateTime();
        description = "Descripcion";
        maxUserCount = 2;
        teamBoards = new List<Board>();
        team = new Team(nameTeam, dateCreationTeam, description, maxUserCount);
        }

        [TestMethod]
        public void UserAdministratorGetNameTest()
        {
            Assert.AreEqual(userAdministrator.getName(), nameUser);
        }
        
        [TestMethod]
        public void UserAdministratorSetNameTest()
        {
            string changeNameUser = "NombreCambiado";
            userAdministrator.setName(changeNameUser);
            Assert.AreEqual(userAdministrator.getName(), changeNameUser);
        }

        [TestMethod]
        public void UserAdministratorGetLastNameTest()
        {
            Assert.AreEqual(userAdministrator.getLastName(), lastNameUser);
        }

        [TestMethod]
        public void UserAdministratorSetLastNameTest()
        {
            string changeLastNameUser = "ApellidoCambiado";
            userAdministrator.setLastName(changeLastNameUser);
            Assert.AreEqual(userAdministrator.getLastName(), changeLastNameUser);
        }

        [TestMethod]
        public void UserAdministratorGetEmailTest()
        {
            Assert.AreEqual(userAdministrator.getEmail(), emailUser);
        }

        [TestMethod]
        public void UserAdministratorSetEmailTest()
        {
            string changeEmailUser = "EmailCambiado";
            userAdministrator.setEmail(changeEmailUser);
            Assert.AreEqual(userAdministrator.getEmail(), changeEmailUser);
        }

        [TestMethod]
        public void UserAdministratorGetBirthDateTest()
        {
            Assert.AreEqual(userAdministrator.getBirthDate(), birthDateUser);
        }

        [TestMethod]
        public void UserAdministratorSetBirthDateTest()
        {
            DateTime birthDateAcambiar = new DateTime();
            DateTime.TryParse("2/2/2000", out birthDateAcambiar);
            userAdministrator.setBirthDate(birthDateAcambiar);
            Assert.AreEqual(userAdministrator.getBirthDate(), birthDateAcambiar);
        }

        [TestMethod]
        public void UserAdministratorGetPasswordTest()
        {
            Assert.AreEqual(userAdministrator.getPassword(), passwordUser);
        }

        [TestMethod]
        public void UserAdministratorSetPasswordTest()
        {
            string changePasswordUserAdministration = "PasswordCambiado";
            userAdministrator.setPassword(changePasswordUserAdministration);
            Assert.AreEqual(userAdministrator.getPassword(), changePasswordUserAdministration);
        }

        /*
        [TestMethod]
        public void UserAdministratorChangePasswordTest()
        {
            UserCollaborator user = new UserCollaborator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser);
            string changePasswordUser = "PasswordCambiado";
            userAdministrator.ChangePassword(user, changePasswordUser);
            Assert.AreEqual(userAdministrator.getPassword(), changePasswordUser);
        }        

        [TestMethod]
        public void UserAdministratorChangePasswordDefaultTest()
        {
            User user = new UserCollaborator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser);
            userAdministrator.ChangePasswordDefault(user);
            Assert.AreEqual(user.getPassword(), nameUser);
        }
        */
        
        /*
        [TestMethod]
        public void UserAdministratorAddUserToTeamTest()
        {
            User user = new UserCollaborator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser);
            Assert.IsTrue(userAdministrator.AddUserToTeam(user, team));
        }
        */
        /*
        [TestMethod]
        public void UserAdministratorAddUserToTeamTwiceTest()
        {
            User user = new UserCollaborator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser);
            userAdministrator.AddUserToTeam(user, team);
            Assert.IsFalse(userAdministrator.AddUserToTeam(user, team));
        }
        */
        /*
        [TestMethod]
        public void UserAdministratorAddUserToTeamFullTest()
        {
            User userFirst = new UserCollaborator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser);
            User userSecond = new UserCollaborator("NombreUserSecond", "ApellidoUserSecond", "EmailUserSecond", birthDateUser, "PasswordUserSecond");
            userAdministrator.AddUserToTeam(userFirst, team);
            Assert.IsFalse(userAdministrator.AddUserToTeam(userSecond, team));
        }
        */

        [TestMethod]
        public void UserAdministratorAddTwoUsersToTeamTest()
        {
            User userFirst = new UserCollaborator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser);
            List<Team> teamsUserSecond = new List<Team>();
            User userSecond = new UserCollaborator("NombreUserSecond", "ApellidoUserSecond", "EmailUserSecond", birthDateUser, "PasswordUserSecond");
            UserAdministrator userAdministrator = new UserAdministrator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser);
            userAdministrator.AddUserToTeam(userFirst, team);
            Assert.IsTrue(userAdministrator.AddUserToTeam(userSecond, team));
        }
        /*
        [TestMethod]
        public void UserAdministratorRemoveUserFromTeamTest()
        {
            User userFirst = new UserCollaborator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser);
            List<Team> teamsUserSecond = new List<Team>();
            User userSecond = new UserCollaborator("NombreUserSecond", "ApellidoUserSecond", "EmailUserSecond", birthDateUser, "PasswordUserSecond");
            userAdministrator.AddUserToTeam(userFirst, team);
            userAdministrator.AddUserToTeam(userSecond, team);
            Assert.IsTrue(userAdministrator.RemoveUserTeam(userSecond, team));
        }

        [TestMethod]
        public void UserAdministratorRemoveUserFromTeamEmptyTest()
        {
            User userFirst = new UserCollaborator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser);
            userAdministrator.AddUserToTeam(userFirst, team);
            Assert.IsFalse(userAdministrator.RemoveUserTeam(userFirst, team));
        }

        [TestMethod]
        public void UserAdministratorRemoveUserFromTeamTwiceTest()
        {
            User userFirst = new UserCollaborator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser);
            List<Team> teamsUserSecond = new List<Team>();
            User userSecond = new UserCollaborator("NombreUserSecond", "ApellidoUserSecond", "EmailUserSecond", birthDateUser, "PasswordUserSecond", teamsUserSecond);
            UserAdministrator userAdministrator = new UserAdministrator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser, teamsAdministrator);
            userAdministrator.AddUserToTeam(userFirst, team);
            userAdministrator.AddUserToTeam(userSecond, team);
            userAdministrator.RemoveUserTeam(userSecond, team);
            Assert.IsFalse(userAdministrator.RemoveUserTeam(userSecond, team));
        }

        [TestMethod]
        public void UserAdministratorRemoveAddRemoveUserFromTeamTest()
        {
            User userFirst = new UserCollaborator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser);
            List<Team> teamsUserSecond = new List<Team>();
            User userSecond = new UserCollaborator("NombreUserSecond", "ApellidoUserSecond", "EmailUserSecond", birthDateUser, "PasswordUserSecond");
            userAdministrator.AddUserToTeam(userFirst, team);
            userAdministrator.AddUserToTeam(userSecond, team);
            userAdministrator.RemoveUserTeam(userSecond, team);
            userAdministrator.AddUserToTeam(userSecond, team);
            Assert.IsTrue(userAdministrator.RemoveUserTeam(userSecond, team));
        }
        */
    }
}
