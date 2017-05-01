using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApplicationBusinessLogic
{
    public class Team
    {
        private string name;
        private DateTime creationDate;
        private string description;
        private int maxUserCount;
        private List<User> teamUsers = new List<User>();

        public Team() { }

        public Team(string name, DateTime creationDate, string description, int maxUserCount, List<User> teamUsers)
        {
            this.name = name;
            this.creationDate = creationDate;
            this.description = description;
            this.maxUserCount = maxUserCount;
            this.teamUsers = teamUsers;       
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            if (!isEmpty(name))
                this.name = name;
        }

        private bool isEmpty(string str)
        {
            return (str.Trim().Length == 0);
        }

        public DateTime getCreationDate()
        {
            return this.creationDate;
        }

        public void setCreationDate(DateTime dateTime)
        {
            this.creationDate = dateTime;
        }

        public string getDescription()
        {
            return this.description;
        }

        public void setDescription(string description)
        {
            if(!isEmpty(description))
                this.description = description;
        }

        public int getMaxUserCount()
        {
            return this.maxUserCount;
        }

        public void setMaxUserCount(int maxUserCount)
        {
            this.maxUserCount = maxUserCount;
        }

        public void AddNewUser(User user)
        {
            if (this.teamUsers.Count < this.maxUserCount)
                this.teamUsers.Add(user);
        }

        public List<User> getTeamUsers()
        {
            return this.teamUsers;
        }
    }
}
