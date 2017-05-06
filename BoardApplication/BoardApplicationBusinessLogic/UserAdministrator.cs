using System;
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

        public void AddUserToTeamTest(User user, Team team)
        {
            user.AddToTeam(team);
        }
    }
}
