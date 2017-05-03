using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;
using System.Collections.Generic;

namespace BoardApplicationTest
{

    [TestClass]
    public class BoardUnitTest
    {
        [TestMethod]
        public void BoardGetNameTest()
        {
            Board board = new Board("Nombre");
            Assert.AreEqual(board.getName(), "Nombre");
        }
    }
}
