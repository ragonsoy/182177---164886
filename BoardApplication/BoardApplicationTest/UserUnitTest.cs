using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoardApplicationTest
{
    [TestClass]
    public class UserUnitTest
    {
        [TestMethod]
        public void UserCreateTest()
        {
            User user = new User();
            Assert.AreEqual(user.getName() == "");
        }
    }
}
