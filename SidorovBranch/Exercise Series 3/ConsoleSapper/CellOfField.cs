using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSapper
{
    struct CellOfField
    {
        public CellOfField(int x, int y)
        {
            xCoordinate = x;
            yCoordinate = y;
            numberOfBombs = 0;
            existenceOfBoomb = false;
            isOpened = false;
        }

        private int xCoordinate;
        private int yCoordinate;

        private bool existenceOfBoomb;
        private bool isOpened;
        private int numberOfBombs;

        public int XCoordinate 
        {
            get { return xCoordinate; }
            set { xCoordinate = value; }
        }
        public int YCoordinate 
        {
            get { return yCoordinate; }
            set { yCoordinate = value; }
        }

        public bool ExistenceOfBoomb 
        {
            get { return existenceOfBoomb; }
            set { existenceOfBoomb = value; }
        }
        public bool IsOpened 
        {
            get { return isOpened; }
            set { isOpened = value; }
        }

        public int NumberOfBombs 
        {
            get { return numberOfBombs; }
            set { numberOfBombs = value; }
        }
    }
}
