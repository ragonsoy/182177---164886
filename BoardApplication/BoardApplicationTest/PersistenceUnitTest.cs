using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoardApplicationBusinessLogic.DomainPersistence;
using BoardApplicationBusinessLogic;

namespace BoardApplicationTest
{
    [TestClass]
    public class PersistenceUnitTest
    {
        Persistence persistence;

        [TestInitialize]
        public void Init()
        {
            persistence = new Persistence();
        }

        [TestMethod]
        public void PersistenceAddGetAdministrator()
        {
            DateTime birthDateUser = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDateUser);
            User user = new UserAdministrator("Nombre", "Apellido", "administrator@mail.com", birthDateUser, "password");
            persistence.Add(user);
            Assert.AreEqual(persistence.Get(user), user);
        }

        [TestMethod]
        public void PersistenceCountEmptyAdministrator()
        {            
            Assert.IsTrue(persistence.ElementsCount() == 0);
        }

        [TestMethod]
        public void PersistenceCountOneAdministrator()
        {
            DateTime birthDateUser = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDateUser);
            User user = new UserAdministrator("Nombre", "Apellido", "administrator@mail.com", birthDateUser, "password");
            persistence.Add(user);
            Assert.IsTrue(persistence.ElementsCount() == 1);
        }

        [TestMethod]
        public void PersistenceExistAdministrator()
        {
            DateTime birthDateUser = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDateUser);
            User user = new UserAdministrator("Nombre", "Apellido", "administrator@mail.com", birthDateUser, "password");
            persistence.Add(user);
            Assert.IsTrue(persistence.ElementExist(user));
        }

        [TestMethod]
        public void PersistenceNotExistAdministrator()
        {
            DateTime birthDateUser = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDateUser);
            User user = new UserAdministrator("Nombre", "Apellido", "administrator@mail.com", birthDateUser, "password");
            Assert.IsFalse(persistence.ElementExist(user));
        }

        [TestMethod]
        public void PersistenceRemoveAdministrator()
        {
            DateTime birthDateUser = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDateUser);
            User user = new UserAdministrator("Nombre", "Apellido", "administrator@mail.com", birthDateUser, "password");
            persistence.Add(user);
            Assert.IsTrue(persistence.ElementExist(user));
            persistence.Remove(user);
            Assert.IsFalse(persistence.ElementExist(user));
        }
    }
}
