using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApplicationBusinessLogic
{
    public class Commentary
    {
        private DateTime creationDateTime;
        private User creatorUser;
        private string commentary;
        
        public Commentary(DateTime creationDateTime, User creatorUser, string commentary)
        {
            this.creationDateTime = creationDateTime;
            this.creatorUser = creatorUser;
            this.commentary = commentary;
        }

        public DateTime getCreationDate()
        {
            return this.creationDateTime;
        }

        public void setCreationDate(DateTime creationDateTime)
        {
            this.creationDateTime = creationDateTime;

        }
              
        public User getCreatorUser()
        {
            return this.creatorUser;
        }

        public void setCreatorUser(User creatorUser)
        {
            this.creatorUser = creatorUser;
        }
        
        public string getCommentary()
        {
            return this.commentary;
        }

        public void SetCommentary(string commentary)
        {
            this.commentary = commentary;
        }
    }
}
