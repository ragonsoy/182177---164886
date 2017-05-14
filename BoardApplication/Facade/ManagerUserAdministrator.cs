using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardApplicationBusinessLogic.DomainPersistence;
using BoardApplicationBusinessLogic;

namespace BoardApplicationFacade
{
    public class ManagerUserAdministrator
    {
        PersistenceUserCollaborator persistenceUserCollaborator;
        PersistenceUserAdministration persistenceUserAdministrator;
        UserAdministrator userAdministrator;
        public ManagerUserAdministrator()
        {
            this.persistenceUserCollaborator = new PersistenceUserCollaborator();
            this.persistenceUserAdministrator = new PersistenceUserAdministration();
            this.userAdministrator = new UserAdministrator();
        }

        public void CreateUserCollaborator(string name, string lastName, string email, DateTime birthDate, string password)
        {
            UserCollaborator user = userAdministrator.CreationUserCollaborator(name, lastName, email, birthDate, password);
            persistenceUserCollaborator.Add(user);
        }

        public void CreateUserAdministrator(string name, string lastName, string email, DateTime birthDate, string password)
        {
            UserAdministrator user = userAdministrator.CreationUserAdministrator(name, lastName, email, birthDate, password);
            persistenceUserAdministrator.Add(user);
            persistenceUserCollaborator.Add(user);
        }

        public User GetUserAdministrator(string email)
        {
            try
            {
                User user = new UserAdministrator(email);                
                return persistenceUserAdministrator.Get(user); ;
            }
            catch
            {
                return null;
            }
        }

        public User GetUser(string email)
        {
            User user = new UserCollaborator(email);
            return persistenceUserCollaborator.Get(user);
        }

        public bool ExistsUserAdministrator(string email)
        {
            User user = new UserAdministrator(email);
            return persistenceUserAdministrator.ElementExist(user);
        }

        public bool ExistsUserCollaborator(string email)
        {
            User user = new UserCollaborator(email);
            return persistenceUserCollaborator.ElementExist(user);
        }

        public bool PasswordCorrect(User user, string password)
        {
            return user.PasswordCorrect(password);
        }

        //public void ModifyUser(string name, string lastName, string email, DateTime birthDate, string password)
        //{
        //    User user = new UserCollaborator(name, lastName, email, birthDate, password);
        //    persistenceUserCollaborator.Remove(user);
        //    persistenceUserCollaborator.Add(user);
        //    persistenceUserAdministrator.Remove(user);
        //    persistenceUserAdministrator.Add(user);
        //}

        //public void RemoveUser(string name, string lastName, string email, DateTime birthDate, string password)
        //{
        //    User user = new UserCollaborator(name, lastName, email, birthDate, password);
        //    persistenceUserCollaborator.Remove(persistenceUserCollaborator.Get(user));
        //    persistenceUserAdministrator.Remove(persistenceUserAdministrator.Get(user));
        //}

        //public void AddUserToTeam(User user, Team team)
        //{
        //    if(userAdministrator.AddUserToTeam(user, team))
        //        user.AddToTeam(team);
        //    persistenceUserCollaborator.Remove(user);
        //    persistenceUserAdministrator.Remove(user);
        //    persistenceUserCollaborator.Add(user);
        //    persistenceUserAdministrator.Add(user);
        //}

        //public void RemoveUserToTeam(User user, Team team)
        //{
        //    if (userAdministrator.RemoveUserTeam(user, team))
        //        user.RemoveFromTeam(team);
        //    persistenceUserCollaborator.Remove(user);
        //    persistenceUserAdministrator.Remove(user);
        //    persistenceUserCollaborator.Add(user);
        //    persistenceUserAdministrator.Add(user);
        //}
    }
}
