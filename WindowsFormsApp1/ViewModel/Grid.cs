using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ViewModel
{
    public class Grid
    {
        public static int MAX_HEIGHT = 4;
        public static int MAX_WIDTH = 4;

        public Tile[,] GameGrid { get; set; }

        public Grid(int width, int height)
        {
            GameGrid = new Tile[width, height];
            for (int i = 0; i < MAX_WIDTH; i++)
            {
                for (int j = 0; j < MAX_HEIGHT; j++)
                {
                   GameGrid[i,j] = new Tile(i, j);
                }
            }
        }

        public Tile GetTile(int x, int y)
        {
            return GameGrid[x, y];
        }
    }
}
