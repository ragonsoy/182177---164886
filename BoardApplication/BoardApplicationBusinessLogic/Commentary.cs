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

        public Commentary(DateTime creationDateTime, DateTime resolutionDateTime)
        {
            this.creationDateTime = creationDateTime;
            this.resolutionDateTime = resolutionDateTime;
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
    }
}
