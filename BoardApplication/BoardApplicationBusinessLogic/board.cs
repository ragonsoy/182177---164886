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
        private string description;
        private int height;
        private int wide;

        public Board(string name, Team team, string description, int height, int wide)
        {
            this.name = name;
            this.team = team;
            this.description = description;
            this.height = height;
            this.wide = wide;
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

        public string getDescription()
        {
            return this.description;
        }

        public void setDescripcion(string description)
        {
            this.description = description;
        }

        public int getHeight()
        {
            return this.height;
        }

        public void setHeight(int height)
        {
            this.height = height;
        }

        public int getWide()
        {
            return this.wide;
        }

        public void setWide(int wide)
        {
            this.wide = wide;
        }
        
    }
}
