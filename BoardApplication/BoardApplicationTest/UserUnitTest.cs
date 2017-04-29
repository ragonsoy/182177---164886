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
            String birthDate = "1/1/2000";
            User user = new User("Nombre", "Apellido", "Email", birthDate);            
            Assert.AreEqual(user.getName(), "Nombre");
        }

        [TestMethod]
        public void UserSetNameTest()
        {
            String birthDate = "1/1/2000";
            User user = new User("NombreACambiar", "Apellido", "Email", birthDate);
            user.setName("NombreCambiado");
            Assert.AreEqual(user.getName(), "NombreCambiado");
        }

        [TestMethod]
        public void UserGetLastNameTest()
        {
            String birthDate = "1/1/2000";
            User user = new User("Nombre", "Apellido", "Email", birthDate);
            Assert.AreEqual(user.getLastName(), "Apellido");
        }

        [TestMethod]
        public void UserSetLastNameTest()
        {
            String birthDate = "1/1/2000";
            User user = new User("Nombrer", "ApellidoACambiar", "Email", birthDate);
            user.setLastName("ApellidoCambiado");
            Assert.AreEqual(user.getLastName(), "ApellidoCambiado");
        }

        [TestMethod]
        public void UserGetEmailTest()
        {
            String birthDate = "1/1/2000";
            User user = new User("Nombre", "Apellido", "Email", birthDate);
            Assert.AreEqual(user.getEmail(), "Email");
        }

        [TestMethod]
        public void UserSetEmailTest()
        {
            String birthDate = "1/1/2000";
            User user = new User("Nombrer", "Apellido", "EmailACambiar", birthDate);
            user.setEmail("EmailCambiado");
            Assert.AreEqual(user.getEmail(), "EmailCambiado");
        }

        [TestMethod]
        public void UserGetBirthDateTest()
        {
            String birthDate = "1/1/2000";
            User user = new User("Nombre", "Apellido", "Email", birthDate);
            Assert.AreEqual(user.getBirthDate(), birthDate);
        }

        [TestMethod]
        public void UserSetBirthDateTest()
        {
            String birthDate = "1/1/2000";
            String birthDateAcambiar = "1/1/2000";
            User user = new User("Nombrer", "Apellido", "Email", birthDate);
            user.setBirthDate(birthDateAcambiar);
            Assert.AreEqual(user.getBirthDate(), birthDateAcambiar);
        }


    }
}
