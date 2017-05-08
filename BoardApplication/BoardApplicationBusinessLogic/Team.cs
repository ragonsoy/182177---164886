using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApplicationBusinessLogic
{
    public class Team
    {
        private string name;
        private DateTime creationDate;
        private string description;
        private int maxUserCount;
        private List<Board> teamBoards = new List<Board>();
        private int countUser;

        private int minimunUser = 1;

        public Team() { }

        public Team(string name, DateTime creationDate, string description, int maxUserCount, List<Board> teamBoards)
        {
            this.name = name;
            this.creationDate = creationDate;
            this.description = description;
            this.maxUserCount = maxUserCount;
            this.teamBoards = teamBoards;
            this.countUser = 0;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            if (!isEmpty(name))
                this.name = name;
        }

        private bool isEmpty(string str)
        {
            return (str.Trim().Length == 0);
        }

        public DateTime getCreationDate()
        {
            return this.creationDate;
        }

        public void setCreationDate(DateTime dateTime)
        {
            this.creationDate = dateTime;
        }

        public string getDescription()
        {
            return this.description;
        }

        public void setDescription(string description)
        {
            if(!isEmpty(description))
                this.description = description;
        }

        public int getMaxUserCount()
        {
            return this.maxUserCount;
        }

        public void setMaxUserCount(int maxUserCount)
        {
            this.maxUserCount = maxUserCount;
        }
        
        private bool TeamFull()
        {
            return (countUser == maxUserCount);
        }

        public bool AddUserToTeam()
        {
            if (TeamFull())
                return false;
            countUser++;
            return true;
        }

        public bool RemoveUserTeam()
        {
            if (!UniqueUser())
            {
                countUser--;
                return true;
            }
            return false;
        }

        private bool UniqueUser()
        {
            return countUser == minimunUser;
        }

        public void AddBoard(Board board)
        {
            this.teamBoards.Add(board);   
        }

        //public void ModifyBoard(Board board)
        //{
        //    if (this.teamBoards.Contains(board))
        //    {
        //        Board teamBoard = this.GetBoard(board);
        //        teamBoard.ModifyBoard(board);
        //    }
        //}

        //private Board GetBoard(Board board)
        //{
        //    foreach (Board boardWanted in this.teamBoards)
        //    {
        //        if (boardWanted.Equals(board))
        //            return boardWanted;
        //    }
        //    return board;
        //}
    }
}
