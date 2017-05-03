using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApplicationBusinessLogic
{
    public class Board
    {
        private string name;
        private Team team;

        public Board(string name, Team team)
        {
            this.name = name;
            this.team = team;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public Team getBoardTeam()
        {
            return this.team;

        }

        public void SetBoardTeam(Team boardNewTeam)
        {
            this.team = boardNewTeam;
        }
    }
}
