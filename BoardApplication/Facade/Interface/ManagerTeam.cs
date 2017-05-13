using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardApplicationBusinessLogic.DomainPersistence;

namespace BoardApplicationFacade.Interface
{
    class ManagerTeam
    {
        Persistence persistence;
        public ManagerTeam(Persistence persistence)
        {
            this.persistence = persistence;
        }

        public void CreateTeam(string name, DateTime creationDate, string description, int maxUserCount)
        {
            Team team = new Team(name,creationDate,description,maxUserCount);
            persistence.Add(team);
        }

        public Team QueryTeam(string name, DateTime creationDate, string description, int maxUserCount)
        {
            Team team = new Team(name, creationDate, description, maxUserCount);
            return (Team)persistence.Query(team);
        }

        public void ModifyTeam(string name, DateTime creationDate, string description, int maxUserCount)
        {
            Team team = new Team(name, creationDate, description, maxUserCount);
            persistence.Remove(team);
            persistence.Add(team);
        }

        public void RemoveTeam(string name, DateTime creationDate, string description, int maxUserCount)
        {
            Team team = new Team(name, creationDate, description, maxUserCount);
            persistence.Remove(persistence.Query(team));
        }
    }
}
