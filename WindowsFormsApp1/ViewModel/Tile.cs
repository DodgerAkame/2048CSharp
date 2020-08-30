using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ViewModel
{
    public class Tile
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public int Value { get; set; }

        public Tile(int x, int y)
        {
            Value = 0;
            XPosition = x;
            YPosition = y;
        }
    }
}
