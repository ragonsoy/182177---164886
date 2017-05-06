using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApplicationBusinessLogic
{
    public class User
    {
        private string name;
        private string lastName;
        private string email;
        private DateTime birthDate;
        private string password;
        private List<Team> teams;

        public User(string name, string lastName, string email, DateTime birthDate, string password, List<Team> teams)
        {
            this.name = name;
            this.lastName = lastName;
            this.email = email;
            this.birthDate = birthDate;
            this.password = password;
            this.teams = teams;
        }
        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public DateTime getBirthDate()
        {
            return this.birthDate;
        }

        public void setBirthDate(DateTime birthDate)
        {
            this.birthDate = birthDate;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public List<Team> getTeams()
        {
            return teams;
        }

        public void setTeams(List<Team> teams)
        {
            this.teams = teams;
        }

        public bool AddToTeam(Team team)
        {
            if (!UserIsOnTeam(team))
            {
                this.teams.Add(team);
                return true;
            }
            return false;
        }

        public bool UserIsOnTeam(Team team)
        {
            return this.teams.Contains(team);
        }
    }
}
