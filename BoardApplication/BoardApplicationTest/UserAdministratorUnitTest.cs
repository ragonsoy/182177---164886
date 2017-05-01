using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;

namespace BoardApplicationTest
{
    [TestClass]
    public class UserAdministratorUnitTest
    {
        [TestMethod]
        public void UserAdministratorGetNameTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User userAdministrator = new UserAdministrator("Nombre", "Apellido", "Email", birthDate, "Password");
            Assert.AreEqual(userAdministrator.getName(), "Nombre");
        }
        
        [TestMethod]
        public void UserAdministratorSetNameTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User userAdministrator = new UserAdministrator("NombreACambiar", "Apellido", "Email", birthDate, "Password");
            userAdministrator.setName("NombreCambiado");
            Assert.AreEqual(userAdministrator.getName(), "NombreCambiado");
        }

        [TestMethod]
        public void UserAdministratorGetLastNameTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User userAdministrator = new UserAdministrator("Nombre", "Apellido", "Email", birthDate, "Password");
            Assert.AreEqual(userAdministrator.getLastName(), "Apellido");
        }

        [TestMethod]
        public void UserAdministratorSetLastNameTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User userAdministrator = new UserAdministrator("Nombrer", "ApellidoACambiar", "Email", birthDate, "Password");
            userAdministrator.setLastName("ApellidoCambiado");
            Assert.AreEqual(userAdministrator.getLastName(), "ApellidoCambiado");
        }

        [TestMethod]
        public void UserAdministratorGetEmailTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User userAdministrator = new UserAdministrator("Nombre", "Apellido", "Email", birthDate, "Password");
            Assert.AreEqual(userAdministrator.getEmail(), "Email");
        }

        [TestMethod]
        public void UserAdministratorSetEmailTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User userAdministrator = new UserAdministrator("Nombrer", "Apellido", "EmailACambiar", birthDate, "Password");
            userAdministrator.setEmail("EmailCambiado");
            Assert.AreEqual(userAdministrator.getEmail(), "EmailCambiado");
        }

        [TestMethod]
        public void UserAdministratorGetBirthDateTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User userAdministrator = new UserAdministrator("Nombre", "Apellido", "Email", birthDate, "Password");
            Assert.AreEqual(userAdministrator.getBirthDate(), birthDate);
        }

        [TestMethod]
        public void UserAdministratorSetBirthDateTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            DateTime birthDateAcambiar = new DateTime();
            DateTime.TryParse("2/2/2000", out birthDateAcambiar);
            User userAdministrator = new UserAdministrator("Nombrer", "Apellido", "Email", birthDate, "Password");
            userAdministrator.setBirthDate(birthDateAcambiar);
            Assert.AreEqual(userAdministrator.getBirthDate(), birthDateAcambiar);
        }

        [TestMethod]
        public void UserAdministratorGetPasswordTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User userAdministrator = new UserAdministrator("Nombre", "Apellido", "Email", birthDate, "Password");
            Assert.AreEqual(userAdministrator.getPassword(), "Password");
        }

        [TestMethod]
        public void UserAdministratorSetPassword()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User userAdministrator = new UserAdministrator("Nombrer", "Apellido", "Email", birthDate, "PasswordACambiar");
            userAdministrator.setPassword("PasswordCambiado");
            Assert.AreEqual(userAdministrator.getPassword(), "PasswordCambiado");
        }

        [TestMethod]
        public void UserAdministratorChangePasswordTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User user = new User("NombreUser", "ApellidoUser", "EmailUser", birthDate, "PasswordACambiar");
            UserAdministrator userAdministrator = new UserAdministrator("NombreAdmin", "ApellidoAdmin", "EmailAdmin", birthDate, "Password");
            userAdministrator.ChangePassword(user, "PasswordCambiado");
            Assert.AreEqual(user.getPassword(), "PasswordCambiado");
        }


    }
}
