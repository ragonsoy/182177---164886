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
        private int width;
        private List<BoardElement> boardElements;

        public Board(string name, Team team, string description, int height, int width, List<BoardElement> boardElements)
        {
            this.name = name;
            this.team = team;
            this.description = description;
            this.height = height;
            this.width = width;
            this.boardElements = boardElements;
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

        public int getWidth()
        {
            return this.width;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }

        public List<BoardElement> getBoardElements()
        {
            return this.boardElements;
        }

        public void AddBoardElements(BoardElement element)
        {
            this.boardElements.Add(element);
        }

        public void RemoveBoardElements(BoardElement element)
        {
            this.boardElements.Remove(element);
        }
    }
}
