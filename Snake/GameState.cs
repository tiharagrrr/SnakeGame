using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class GameState
    {
        public int Rows { get; }
        public int Cols { get; }
        public GridValue[,] Grid { get; }
    }
}
