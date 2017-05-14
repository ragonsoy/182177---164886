using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApplicationBusinessLogic.DomainPersistence
{
    public class PersistenceTeam
    {
        List<Team> collection;
        public PersistenceTeam()
        {
            collection = new List<Team>();
        }

        public void Add(Team obj)
        {
            collection.Add(obj);
        }

        public void Remove(Team obj)
        {
            collection.Remove(obj);
        }

        public Team Get(Team obj)
        {
            Team objectReturn = new Team();
            foreach (var item in collection)
            {               
                if (base.Equals(obj))
                    objectReturn = item;
            }
            return objectReturn;
        }

        public int ElementsCount()
        {
            return collection.Count();
        }

        public bool ElementExist(Team obj)
        {
            return collection.Contains(obj);
        }
    }
}
