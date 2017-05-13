﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApplicationBusinessLogic
{
    public class UserAdministrator : User
    {
        
        public UserAdministrator(string name, string lastName, string email, DateTime birthDate, string password) 
            : base (name, lastName, email, birthDate, password)
        {
        
        }

        public UserCollaborator CreationUserCollaborator(string name, string lastName, string email, DateTime birthDate, string password)
        {
            return new UserCollaborator(name,lastName,email,birthDate,password);
        }

        public UserAdministrator CreationUserAdministrator(string name, string lastName, string email, DateTime birthDate, string password)
        {
            return new UserAdministrator(name, lastName, email, birthDate, password);
        }
<<<<<<< HEAD:BoardApplication/BoardApplicationBusinessLogic/Domain/UserAdministrator.cs

        







































=======
                
>>>>>>> b36a2f9a40b318acededeb3ab4a31027b6db7def:BoardApplication/BoardApplicationBusinessLogic/Domain/UserAdministrator.cs
        public void ChangePassword(User user, string password)
        {
            user.setPassword(password);
        }

        public void ChangePasswordDefault(User user)
        {
            user.setPassword(user.getName());
        }




        public bool AddUserToTeam(User user, Team team)
        {
            if(team.AddUserToTeam())
            {
                return user.AddToTeam(team);
            }
            return false;            
        }

        public bool RemoveUserTeam(User user, Team team)
        {
            if (team.RemoveUserTeam())
            {
                return user.RemoveFromTeam(team);
            }
            return false;
        }
    }
}
