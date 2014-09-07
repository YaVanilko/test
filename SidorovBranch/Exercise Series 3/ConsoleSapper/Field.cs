using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSapper
{
    class Field
    {
        #region

        private CellOfField[,] CellsArray;

        private int xSize;
        private int ySize;
        private int numberOfBombs;
        private int numberOfOpenedCells;

        #endregion

        public Field(int xSize, int ySize)
        {
            this.xSize = xSize;
            this.ySize = ySize;

            if (xSize <= 0 || ySize <= 0)
            {
                throw new IndexOutOfRangeException();
            }

            CellsArray = new CellOfField[ySize + 2, xSize + 2];

            for (int i = 0; i < CellsArray.GetLength(1); ++i)
                for (int j = 0; j < CellsArray.GetLength(0); ++j)
                    CellsArray[j, i] = new CellOfField(i, j);
        }

        public void PrintField() 
        {
            // вывод текущего состояния поля
            for (int j = 1; j <= ySize; ++j)
            {
                Console.WriteLine("\n");
                for (int i = 1; i <= xSize; ++i)
                {
                    if (CellsArray[j, i].IsOpened && CellsArray[j, i].ExistenceOfBoomb)
                        Console.Write(" M");
                    else if(!CellsArray[j, i].IsOpened)
                        Console.Write(" ?");
                    else
                        Console.Write(" " + CellsArray[j, i].NumberOfBombs);
                }
            }
            Console.WriteLine("\n");
        }

        public bool SetBombsAtField(int numberOfBombs) 
        {
            this.numberOfBombs = numberOfBombs;

            if (numberOfBombs > xSize * ySize && numberOfBombs < 0)
                return false;

            // формируем список уникальных адресов 
            // (порядкового номера) мин
            List<int> numList = new List<int>();
            for (int i = 1; i <= xSize * ySize; ++i)
                numList.Add(i);

            // даем случайный адрес каждому номеру мины
            Random rand = new Random();
            int temp;

            // массив координат мин
            int[,] coord = new int[2, numberOfBombs];

            for (int i = 0; i < numberOfBombs; ++i)
            {
                // Выбираем случайный элемент из списка
                temp = rand.Next(0, numList.Count - 1);

                // пересчитываем номер в координату
                coord[0, i] = numList[temp] / xSize + 1;
                coord[1, i] = numList[temp] % xSize;

                // Удаляем выбраный элемент, чтобы не повторится
                numList.RemoveAt(temp);
            }

            // заполнение ячеек со случайными адресами минами
            for (int i = 0; i < numberOfBombs; ++i)
                CellsArray[coord[0, i], coord[1, i]].ExistenceOfBoomb = true;

            for (int j = 1; j <= ySize; ++j) 
            {
                for (int i = 1; i <= xSize; ++i)
                {
                    CellsArray[j, i].IsOpened = false;

                    CellsArray[j, i].NumberOfBombs = CountingBombsAroundCell(
                        CellsArray[j, i].XCoordinate,
                        CellsArray[j, i].YCoordinate);
                }
            }
            return true; 
        }
        
        public bool IsBombsAt( int x, int y) 
        {
            if (CellsArray[y, x].ExistenceOfBoomb)
            {
                for (int j = 1; j <= ySize; ++j)
                {
                    for (int i = 1; i <= xSize; ++i)
                    {
                        CellsArray[j, i].IsOpened = true;
                    }
                }
                return true;
            }
            else
            {
                if (!CellsArray[y, x].IsOpened)
                {
                    CellsArray[y, x].IsOpened = true;
                    ++numberOfOpenedCells;
                }
                return false;
            }
        }

        private int CountingBombsAroundCell(int x, int y) 
        {
            int sum = 0;
            // подсчет колличества мин вокруг введеннойй позиции
            for (int i = x - 1; i < x + 2; ++i )
                for (int j = y - 1; j < y + 2; ++j)
                    if (CellsArray[j, i].ExistenceOfBoomb)
                        ++sum;
            return sum; 
        }

        public bool IsWinCondition() 
        {
            if (numberOfOpenedCells == xSize * ySize - numberOfBombs)
                return true;
            else
                return false;
        }
    }
}
