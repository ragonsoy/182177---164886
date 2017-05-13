using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardApplicationBusinessLogic;
using BoardApplicationBusinessLogic.DomainPersistence;

namespace BoardApplicationBusinessLogic.Interface
{
    class ManagerBoard
    {
        Persistence persistence;
        public ManagerBoard(Persistence persistence)
        {
            this.persistence = persistence;
        }

        public void CreateBoard(string name, string description, int height, int width)
        {
            Board board = new Board(name, description, height, width);
            persistence.Add(board);
        }

        public Board QueryBoard(string name, string description, int height, int width)
        {
            Board board = new Board(name, description, height, width);
            return (Board)persistence.Query(board);
        }

        public void ModifyBoard(string name, string description, int height, int width)
        {
            Board board = new Board(name, description, height, width);
            persistence.Remove(board);
            persistence.Add(board);
        }

        public void RemoveBoard(string name, string description, int height, int width)
        {
            Board board = new Board(name, description, height, width);
            persistence.Remove(persistence.Query(board));
        }
    }
}
