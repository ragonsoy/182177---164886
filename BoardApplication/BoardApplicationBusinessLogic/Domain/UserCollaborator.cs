using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApplicationBusinessLogic
{
    public class UserCollaborator : User
    {
        
        public UserCollaborator(string name, string lastName, string email, DateTime birthDate, string password) 
            : base (name, lastName, email, birthDate, password)
        {
        
        }

        
    }
}
