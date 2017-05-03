using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApplicationBusinessLogic
{
    public class EndCommentary : Commentary
    {

        private DateTime creationDateTime;
        private User creatorUser;
        private string commentary;
        private DateTime resolutionDateTime;
        private User resolutionUser;

        public EndCommentary(DateTime creationDateTime, DateTime resolutionDateTime, User creatorUser, User resolutionUser, string commentary) :
            base(creationDateTime, creatorUser, commentary)
        {
            this.resolutionDateTime = resolutionDateTime;
            this.resolutionUser = resolutionUser;            
        }

        public DateTime getResolutionDate()
        {
            return this.resolutionDateTime;
        }

        public void setResolutionDate(DateTime resolutionDateTime)
        {
            this.resolutionDateTime = resolutionDateTime;
        }
        public User getResolutionUser()
        {
            return this.resolutionUser;
        }

        public void setResolutionUser(User resolutionUser)
        {
            this.resolutionUser = resolutionUser;
        }
    }
}
