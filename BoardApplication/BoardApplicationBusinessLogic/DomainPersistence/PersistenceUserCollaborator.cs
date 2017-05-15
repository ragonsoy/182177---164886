using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApplicationBusinessLogic.DomainPersistence
{
    public class PersistenceUserCollaborator
    {
        List<User> collection;
        public PersistenceUserCollaborator()
        {
            collection = new List<User>();
        }

        public void Add(User obj)
        {
            collection.Add(obj);
        }

        public void Remove(UserCollaborator obj)
        {
            collection.Remove(obj);
        }

        public UserCollaborator Get(UserCollaborator obj)
        {
            UserCollaborator objectReturn = new UserCollaborator();
            foreach (UserCollaborator item in collection)
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
