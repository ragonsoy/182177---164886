using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;

namespace BoardApplicationTest
{
    [TestClass]
    public class UserUnitTest
    {
        [TestMethod]
        public void UserGetNameTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User user = new User("Nombre", "Apellido", "Email", birthDate, "Password");            
            Assert.AreEqual(user.getName(), "Nombre");
        }

        [TestMethod]
        public void UserSetNameTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User user = new User("NombreACambiar", "Apellido", "Email", birthDate, "Password");
            user.setName("NombreCambiado");
            Assert.AreEqual(user.getName(), "NombreCambiado");
        }

        [TestMethod]
        public void UserGetLastNameTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User user = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            Assert.AreEqual(user.getLastName(), "Apellido");
        }

        [TestMethod]
        public void UserSetLastNameTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User user = new User("Nombrer", "ApellidoACambiar", "Email", birthDate, "Password");
            user.setLastName("ApellidoCambiado");
            Assert.AreEqual(user.getLastName(), "ApellidoCambiado");
        }

        [TestMethod]
        public void UserGetEmailTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User user = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            Assert.AreEqual(user.getEmail(), "Email");
        }

        [TestMethod]
        public void UserSetEmailTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User user = new User("Nombrer", "Apellido", "EmailACambiar", birthDate, "Password");
            user.setEmail("EmailCambiado");
            Assert.AreEqual(user.getEmail(), "EmailCambiado");
        }

        [TestMethod]
        public void UserGetBirthDateTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User user = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            Assert.AreEqual(user.getBirthDate(), birthDate);
        }

        [TestMethod]
        public void UserSetBirthDateTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            DateTime birthDateAcambiar = new DateTime();
            DateTime.TryParse("2/2/2000", out birthDateAcambiar);
            User user = new User("Nombrer", "Apellido", "Email", birthDate, "Password");
            user.setBirthDate(birthDateAcambiar);
            Assert.AreEqual(user.getBirthDate(), birthDateAcambiar);
        }

        [TestMethod]
        public void UserGetPasswordTest()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User user = new User("Nombre", "Apellido", "Email", birthDate, "Password");
            Assert.AreEqual(user.getPassword(), "Password");
        }

        [TestMethod]
        public void UserSetPassword()
        {
            DateTime birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            User user = new User("Nombrer", "Apellido", "Email", birthDate, "PasswordACambiar");
            user.setPassword("PasswordCambiado");
            Assert.AreEqual(user.getPassword(), "PasswordCambiado");
        }


    }
}
