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
        UserAdministrator userAdministrator;
        string nameTeam;
        DateTime dateCreationTeam;
        string description;
        int maxUserCount;
        Team team;
        Team teamTwo;

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
            userAdministrator = new UserAdministrator(nameUser, lastNameUser, emailUser, birthDateUser, passwordUser);
        }
        public void dataForTeamsAdministratorTest()
        {
            nameTeam = "Equipo";
            dateCreationTeam = new DateTime();
            description = "Descripcion";
            maxUserCount = 2;
            team = new Team(nameTeam, dateCreationTeam, description, maxUserCount);
            teamTwo = new Team("dos", dateCreationTeam, description, maxUserCount);
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

        [TestMethod]
        public void UserAdministratorEqualsTest()
        {
            Assert.IsTrue(userAdministrator.Equals(userAdministrator));
        }

        [TestMethod]
        public void UserAdministratorCreationUserCollaboratorTest()
        {
            User userCollaborator = userAdministrator.CreationUserCollaborator("collaborator", "collaborator", "collaborator", birthDateUser, "collaborator");
            Assert.IsTrue(userCollaborator.Equals(userCollaborator) );
        }

        [TestMethod]
        public void UserAdministratorCreationUserAdministratorTest()
        {
            User userAdmin = userAdministrator.CreationUserAdministrator("userAdmin", "userAdmin", "userAdmin", birthDateUser, "userAdmin");
            Assert.IsTrue(userAdmin.Equals(userAdmin));
        }

        [TestMethod]
        public void UserAdministratorChangePasswordTest()
        {
            User userCollaborator = userAdministrator.CreationUserCollaborator("collaborator", "collaborator", "collaborator", birthDateUser, "collaborator");
            userAdministrator.ChangePassword(userCollaborator, "NuevoPass");
            Assert.AreEqual(userCollaborator.getPassword(), "NuevoPass");
        }

        [TestMethod]
        public void UserAdministratorChangePasswordDefaultTest()
        {
            User userCollaborator = userAdministrator.CreationUserCollaborator("collaborator", "collaborator", "collaborator", birthDateUser, "collaborator");
            userAdministrator.ChangePasswordDefault(userCollaborator);
            Assert.AreEqual(userCollaborator.getPassword(), "collaborator");
        }

        [TestMethod]
        public void UserAdministratorAddUserToTeamTest()
        {
            User userCollaborator = userAdministrator.CreationUserCollaborator("collaborator", "collaborator", "collaborator", birthDateUser, "collaborator");
            userAdministrator.AddUserToTeam(userCollaborator, team);
            Assert.AreEqual(userCollaborator.getTeams().Count, 1);
        }

        [TestMethod]
        public void UserAdministratorRemoveUserTeamTest()
        {
            User userCollaborator = userAdministrator.CreationUserCollaborator("collaborator", "collaborator", "collaborator", birthDateUser, "collaborator");
            User userCollaboratorTwo = userAdministrator.CreationUserCollaborator("userCollaboratorTwo", "userCollaboratorTwo", "userCollaboratorTwo", birthDateUser, "userCollaboratorTwo");
            userAdministrator.AddUserToTeam(userCollaborator, team);
            userAdministrator.AddUserToTeam(userCollaborator, teamTwo);
            userAdministrator.AddUserToTeam(userCollaboratorTwo, team);
            userAdministrator.AddUserToTeam(userCollaboratorTwo, teamTwo);
            userAdministrator.RemoveUserTeam(userCollaborator, team);
            Assert.AreEqual(userCollaborator.getTeams().Count, 1);
        }

    }
}
