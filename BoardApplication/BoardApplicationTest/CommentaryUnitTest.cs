using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic;
using System.Collections.Generic;

namespace BoardApplicationTest
{
    
    [TestClass]
    public class CommentaryUnitTest
    {

        [TestMethod]
        public void CommentaryGetCreationDateTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            Commentary commentary = new Commentary(creationDateTime, resolutionDateTime);
            Assert.AreEqual(commentary.getCreationDate(), creationDateTime);
        }

        [TestMethod]
        public void CommentarySetCreationDateTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            Commentary commentary = new Commentary(creationDateTime, resolutionDateTime);
            DateTime creationDateTimeNew = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTimeNew);
            commentary.setCreationDate(creationDateTimeNew);
            Assert.AreEqual(commentary.getCreationDate(), creationDateTimeNew);
        }

        [TestMethod]
        public void CommentaryGetResolutionDateTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            Commentary commentary = new Commentary(creationDateTime, resolutionDateTime);
            Assert.AreEqual(commentary.getResolutionDate(), resolutionDateTime);
        }

        [TestMethod]
        public void CommentarySetResolutionDateTest()
        {
            DateTime creationDateTime = new DateTime();
            DateTime.TryParse("1/1/2000", out creationDateTime);
            DateTime resolutionDateTime = new DateTime();
            DateTime.TryParse("2/1/2000", out creationDateTime);
            Commentary commentary = new Commentary(creationDateTime, resolutionDateTime);
            DateTime resolutionDateTimeNew = new DateTime();
            DateTime.TryParse("2/2/2000", out resolutionDateTimeNew);
            commentary.setResolutionDate(resolutionDateTimeNew);
            Assert.AreEqual(commentary.getResolutionDate(), resolutionDateTimeNew);
        }
    }
}
