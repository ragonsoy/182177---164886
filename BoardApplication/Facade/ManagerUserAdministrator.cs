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
        PersistenceTeam persistanceTeams;
        UserAdministrator userAdministrator;
        public ManagerUserAdministrator(PersistenceUserAdministration persistenceUserAdministrator, PersistenceUserCollaborator persistenceUserCollaborator, PersistenceTeam persistanceTeams)
        {
            this.persistenceUserCollaborator = persistenceUserCollaborator;
            this.persistenceUserAdministrator = persistenceUserAdministrator;
            this.persistanceTeams = persistanceTeams;
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
            UserCollaborator userCollaborator = userAdministrator.CreationUserCollaborator(name, lastName, email, birthDate, password);
            persistenceUserCollaborator.Add(userCollaborator);
        }

        public UserAdministrator GetUserAdministrator(string email)
        {
            try
            {
                UserAdministrator user = new UserAdministrator(email);                
                return persistenceUserAdministrator.Get(user); ;
            }
            catch
            {
                return null;
            }
        }

        public void SetActualUserAdministrator(string email)
        {
            this.userAdministrator = GetUserAdministrator(email);
        }
        
        public bool ExistsUserAdministrator(string email)
        {
            User user = new UserAdministrator(email);
            return persistenceUserAdministrator.ElementExist(user);
        }
        
        public bool PasswordCorrect(string password)
        {
            return this.userAdministrator.PasswordCorrect(password);
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

        public void CreateTeam(string name, DateTime creationDate, string description, int maxUserCount)
        {
            Team team = new Team(name, creationDate, description, maxUserCount);
            persistanceTeams.Add(team);            
        }
                

        public void AddUserToTeam(UserCollaborator user, Team team)
        {
            if (userAdministrator.AddUserToTeam(user, team))
                user.AddToTeam(team);
            persistenceUserCollaborator.Remove(user);
            persistenceUserCollaborator.Add(user);
        }

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
