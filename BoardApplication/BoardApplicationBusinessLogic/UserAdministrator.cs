﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApplicationBusinessLogic
{
    public class UserAdministrator : User
    {
        
        public UserAdministrator(string name, string lastName, string email, DateTime birthDate, string password, List<Team> teams) 
            : base (name, lastName, email, birthDate, password, teams)
        {
        
        }

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
