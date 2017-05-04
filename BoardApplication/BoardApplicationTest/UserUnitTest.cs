using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;

namespace BoardApplicationTest
{
    [TestClass]
    public class UserUnitTest
    {
        DateTime birthDate;
        string nameUser;
        string lastNameUser;
        string emailUser;
        string passwordUser;

        [TestInitialize]
        public void Init()
        {
            dataForUserTest();
        }
        public void dataForUserTest()
        {
            birthDate = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDate);
            nameUser = "Nombre";
            lastNameUser = "Apellido";
            emailUser = "Email";
            passwordUser = "Password";
        }

        [TestMethod]
        public void UserGetNameTest()
        {            
            User user = new User(nameUser, lastNameUser, emailUser, birthDate, passwordUser);            
            Assert.AreEqual(user.getName(), nameUser);
        }

        [TestMethod]
        public void UserSetNameTest()
        {
            string changeNameUser = "NombreCambiado";
            User user = new User(nameUser, lastNameUser, emailUser, birthDate, passwordUser);
            user.setName(changeNameUser);
            Assert.AreEqual(user.getName(), changeNameUser);
        }

        [TestMethod]
        public void UserGetLastNameTest()
        {
            User user = new User(nameUser, lastNameUser, emailUser, birthDate, passwordUser);
            Assert.AreEqual(user.getLastName(), lastNameUser);
        }

        [TestMethod]
        public void UserSetLastNameTest()
        {
            string changeLastNameUser = "ApellidoCambiado";
            User user = new User(nameUser, lastNameUser, emailUser, birthDate, passwordUser);
            user.setLastName(changeLastNameUser);
            Assert.AreEqual(user.getLastName(), changeLastNameUser);
        }

        [TestMethod]
        public void UserGetEmailTest()
        {
            User user = new User(nameUser, lastNameUser, emailUser, birthDate, passwordUser);
            Assert.AreEqual(user.getEmail(), emailUser);
        }

        [TestMethod]
        public void UserSetEmailTest()
        {
            string changeEmail = "EmailCambiado";
            User user = new User(nameUser, lastNameUser, emailUser, birthDate, passwordUser);
            user.setEmail(changeEmail);
            Assert.AreEqual(user.getEmail(), changeEmail);
        }

        [TestMethod]
        public void UserGetBirthDateTest()
        {
            User user = new User(nameUser, lastNameUser, emailUser, birthDate, passwordUser);
            Assert.AreEqual(user.getBirthDate(), birthDate);
        }

        [TestMethod]
        public void UserSetBirthDateTest()
        {
            DateTime changeBirthDate = new DateTime();
            DateTime.TryParse("2/2/2000", out changeBirthDate);
            User user = new User(nameUser, lastNameUser, emailUser, birthDate, passwordUser);
            user.setBirthDate(changeBirthDate);
            Assert.AreEqual(user.getBirthDate(), changeBirthDate);
        }

        [TestMethod]
        public void UserGetPasswordTest()
        {
            User user = new User(nameUser, lastNameUser, emailUser, birthDate, passwordUser);
            Assert.AreEqual(user.getPassword(), passwordUser);
        }

        [TestMethod]
        public void UserSetPassword()
        {
            string changePassword = "PasswordCambiado";
            User user = new User(nameUser, lastNameUser, emailUser, birthDate, passwordUser);
            user.setPassword(changePassword);
            Assert.AreEqual(user.getPassword(), changePassword);
        }
    }
}
