using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.ViewModel;

namespace WindowsFormsApp1.Business
{
    public class TileBusiness
    {
        public static void DoFusionTile(Tile tileToReceive, Tile tileToDelete)
        {
            tileToReceive = tileToDelete;
            tileToDelete = new Tile(tileToDelete.XPosition, tileToDelete.YPosition);
        }
    }
}
