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
            User user = new User("Nombre", "Apellido");            
            Assert.AreEqual(user.getName(), "Nombre");
        }

        [TestMethod]
        public void UserSetNameTest()
        {
            User user = new User("NombreACambiar", "Apellido");
            user.setName("NombreCambiado");
            Assert.AreEqual(user.getName(), "NombreCambiado");
        }

        [TestMethod]
        public void UserGetLastNameTest()
        {
            User user = new User("Nombre", "Apellido");
            Assert.AreEqual(user.getLastName(), "Apellido");
        }

        [TestMethod]
        public void UserSetLastNameTest()
        {
            User user = new User("NombreACambiar", "ApellidoACambiar");
            user.setLastName("ApellidoCambiado");
            Assert.AreEqual(user.getLastName(), "ApellidoCambiado");
        }


    }
}
