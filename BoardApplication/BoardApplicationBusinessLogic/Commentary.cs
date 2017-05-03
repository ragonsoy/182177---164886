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
        private DateTime resolutionDateTime;
        private User creatorUser;
        private User resolutionUser;

        public Commentary(DateTime creationDateTime, DateTime resolutionDateTime, User creatorUser, User resolutionUser)
        {
            this.creationDateTime = creationDateTime;
            this.resolutionDateTime = resolutionDateTime;
            this.creatorUser = creatorUser;
            this.resolutionUser = resolutionUser;
        }

        public DateTime getCreationDate()
        {
            return this.creationDateTime;
        }

        public void setCreationDate(DateTime creationDateTime)
        {
            this.creationDateTime = creationDateTime;

        }

        public DateTime getResolutionDate()
        {
            return this.resolutionDateTime;
        }

        public void setResolutionDate(DateTime resolutionDateTime)
        {
            this.resolutionDateTime = resolutionDateTime;
        }

        public User getCreatorUser()
        {
            return this.creatorUser;
        }

        public void setCreatorUser(User creatorUser)
        {
            this.creatorUser = creatorUser;
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
