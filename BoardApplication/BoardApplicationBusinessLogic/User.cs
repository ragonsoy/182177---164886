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
        private string birthDate;
        private string password;

        public User(string name, string lastName, string email, string birthDate, string password)
        {
            this.name = name;
            this.lastName = lastName;
            this.email = email;
            this.birthDate = birthDate;
            this.password = password;
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

        public string getBirthDate()
        {
            return this.birthDate;
        }

        public void setBirthDate(string birthDate)
        {
            this.birthDate = birthDate;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string v)
        {
            this.password = "PasswordCambiado";
        }
    }
}
