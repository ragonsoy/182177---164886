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
        public Team(string name, DateTime creationDate)
        {
            this.name = name;
            this.creationDate = creationDate;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            if (isEmpty(name))
                this.name = name;
        }

        private bool isEmpty(string str)
        {
            return (str.Trim().Length > 0);
        }

        public DateTime getCreationDate()
        {
            return this.creationDate;
        }
    }
}
