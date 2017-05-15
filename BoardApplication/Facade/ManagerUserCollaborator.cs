using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardApplicationBusinessLogic.DomainPersistence;
using BoardApplicationBusinessLogic;

namespace BoardApplicationFacade
{
    public class ManagerUserCollaborator
    {
        PersistenceUserCollaborator persistenceUserCollaborator;
        UserCollaborator userCollaborator;
        public ManagerUserCollaborator(PersistenceUserCollaborator persistenceUserCollaborator)
        {
            this.persistenceUserCollaborator = persistenceUserCollaborator;
            this.userCollaborator = new UserCollaborator();
        }

        
        public UserCollaborator GetUserCollaborator(string email)
        {
            try
            {
                UserCollaborator user = new UserCollaborator(email);                
                return persistenceUserCollaborator.Get(user); ;
            }
            catch
            {
                return null;
            }
        }

        public void SetActualUser(string email)
        {
            this.userCollaborator = GetUserCollaborator(email);
        }

        public string GetIDActualUser()
        {
            return this.userCollaborator.getEmail();
        }
        public UserCollaborator GetActualUser()
        {
            return this.userCollaborator;
        }

        public UserCollaborator GetUser(string email)
        {
            UserCollaborator user = new UserCollaborator(email);
            return persistenceUserCollaborator.Get(user);
        }
        public bool ExistsUserCollaborator(string email)
        {
            User user = new UserCollaborator(email);
            return persistenceUserCollaborator.ElementExist(user);
        }
        public bool PasswordCorrect(string password)
        {
            return this.userCollaborator.PasswordCorrect(password);
        }

        public List<Team> GetTeams()
        {
            return this.userCollaborator.getTeams();
        }
    }
}
