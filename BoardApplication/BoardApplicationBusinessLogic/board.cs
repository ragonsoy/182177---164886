﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApplicationBusinessLogic
{
    public class Board
    {
        private string name;
        private string description;
        private int height;
        private int width;
        private List<BoardElement> boardElements;

        public Board(string name, string description, int height, int width)
        {
            this.name = name;
            this.description = description;
            this.height = height;
            this.width = width;
            this.boardElements = new List<BoardElement>();
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
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

        public void ModifyBoard(Board board)
        {
            this.description = board.getDescription();
            this.height = board.getHeight();
            this.width = board.getWidth();
        }
    }
}
