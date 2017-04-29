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

        public User(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
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

        public void setLastName(string v)
        {
            throw new NotImplementedException();
        }
    }
}
