using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardApplicationBusinessLogic.DomainPersistence;
using BoardApplicationBusinessLogic;

namespace BoardApplicationFacade.Interface
{
    public class ManagerUserAdministrator
    {
        Persistence persistenceUserCollaborator;
        Persistence persistenceUserAdministrator;
        UserAdministrator userAdministrator;
        public ManagerUserAdministrator(Persistence persistenceUserCollaborator, Persistence persistenceUserAdministrator, UserAdministrator userAdministrator)
        {
            this.persistenceUserCollaborator = persistenceUserCollaborator;
            this.persistenceUserAdministrator = persistenceUserAdministrator;
            this.userAdministrator = userAdministrator;
        }

        public void CreateUserCollaborator(string name, string lastName, string email, DateTime birthDate, string password)
        {
            User user = userAdministrator.CreationUserCollaborator(name, lastName, email, birthDate, password);
            persistenceUserCollaborator.Add(user);
        }

        public void CreateUserAdministrator(string name, string lastName, string email, DateTime birthDate, string password)
        {
            User user = userAdministrator.CreationUserAdministrator(name, lastName, email, birthDate, password);
            persistenceUserAdministrator.Add(user);
        }

        public User QueryUser(string name, string lastName, string email, DateTime birthDate, string password)
        {
            User user = new UserCollaborator(name, lastName, email, birthDate, password);
            return (User)persistenceUserCollaborator.Query(user);
        }

        public void ModifyUser(string name, string lastName, string email, DateTime birthDate, string password)
        {
            User user = new UserCollaborator(name, lastName, email, birthDate, password);
            persistenceUserCollaborator.Remove(user);
            persistenceUserCollaborator.Add(user);
            persistenceUserAdministrator.Remove(user);
            persistenceUserAdministrator.Add(user);
        }

        public void RemoveUser(string name, string lastName, string email, DateTime birthDate, string password)
        {
            User user = new UserCollaborator(name, lastName, email, birthDate, password);
            persistenceUserCollaborator.Remove(persistenceUserCollaborator.Query(user));
            persistenceUserAdministrator.Remove(persistenceUserAdministrator.Query(user));
        }
    }
}
