﻿using System;
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
            User user = new User("");            
            Assert.AreEqual(user.getName(), "");
        }
    }
}
