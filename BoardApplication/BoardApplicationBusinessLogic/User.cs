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

        public User(string name)
        {
            this.name = name;
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
            return "0";
        }
    }
}
