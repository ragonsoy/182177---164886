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
            User user = new User("Nombre", "Apellido", "Email");            
            Assert.AreEqual(user.getName(), "Nombre");
        }

        [TestMethod]
        public void UserSetNameTest()
        {
            User user = new User("NombreACambiar", "Apellido", "Email");
            user.setName("NombreCambiado");
            Assert.AreEqual(user.getName(), "NombreCambiado");
        }

        [TestMethod]
        public void UserGetLastNameTest()
        {
            User user = new User("Nombre", "Apellido", "Email");
            Assert.AreEqual(user.getLastName(), "Apellido");
        }

        [TestMethod]
        public void UserSetLastNameTest()
        {
            User user = new User("Nombrer", "ApellidoACambiar", "Email");
            user.setLastName("ApellidoCambiado");
            Assert.AreEqual(user.getLastName(), "ApellidoCambiado");
        }

        [TestMethod]
        public void UserGetEmailTest()
        {
            User user = new User("Nombre", "Apellido", "Email");
            Assert.AreEqual(user.getEmail(), "Email");
        }


    }
}
