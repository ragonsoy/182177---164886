using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApplicationBusinessLogic.DomainPersistence
{
    public class PersistenceUserAdministration
    {
        List<User> collection;
        public PersistenceUserAdministration()
        {
            collection = new List<User>();
        }

        public void Add(UserAdministrator obj)
        {
            collection.Add(obj);
        }

        public void Remove(UserAdministrator obj)
        {
            collection.Remove(obj);
        }

        public UserAdministrator Get(UserAdministrator obj)
        {
            UserAdministrator objectReturn = new UserAdministrator();
            foreach (UserAdministrator item in collection)
            {               
                if (item.Equals(obj))
                    objectReturn = item;
            }
            return objectReturn;
        }

        public int ElementsCount()
        {
            return collection.Count();
        }

        public bool ElementExist(User obj)
        {
            bool exist = false;
            foreach (User item in collection)
            {
                if (item.Equals(obj))
                    exist = true;
            }
            return exist;
        }
    }
}
