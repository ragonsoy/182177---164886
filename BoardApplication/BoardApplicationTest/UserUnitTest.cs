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
            User user = new User("Nombre");            
            Assert.AreEqual(user.getName(), "Nombre");
        }

        [TestMethod]
        public void UserSetNameTest()
        {
            User user = new User("NombreACambiar");
            user.setName("NombreCambiado");
            Assert.AreEqual(user.getName(), "NombreCambiado");
        }
    }
}
