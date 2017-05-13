using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardApplicationBusinessLogic.DomainPersistence;
using BoardApplicationBusinessLogic;

namespace BoardApplicationBusinessLogic.Interface
{
    class ManagerCommentary
    {
        Persistence persistence;
        public ManagerCommentary(Persistence persistence)
        {
            this.persistence = persistence;
        }

        public void CreateCommentary(DateTime creationDateTime, User creatorUser, string comment)
        {
            Commentary commentary = new Commentary(creationDateTime, creatorUser, comment);
            persistence.Add(commentary);
        }

        public Commentary QueryCommentary(DateTime creationDateTime, User creatorUser, string comment)
        {
            Commentary commentary = new Commentary(creationDateTime, creatorUser, comment);
            return (Commentary)persistence.Query(commentary);
        }

        public void ModifyCommentary(DateTime creationDateTime, User creatorUser, string comment)
        {
            Commentary commentary = new Commentary(creationDateTime, creatorUser, comment);
            persistence.Remove(commentary);
            persistence.Add(commentary);
        }

        public void RemoveCommentary(DateTime creationDateTime, User creatorUser, string comment)
        {
            Commentary commentary = new Commentary(creationDateTime, creatorUser, comment);
            persistence.Remove(persistence.Query(commentary));
        }
    }
}
