using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle_3
{
    internal class Cell
    {
            public int X;
            public int Y;
            public CellState State = CellState.Empty;
            public Cell(int x, int y)
            {
                X = x;
                Y = y;
            }
        
    }

    public enum CellState
    {
        Empty,
        Reserve,
        Ship,
        Shot,
        Miss
    }
}
