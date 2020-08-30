using WindowsFormsApp1.ViewModel;

namespace WindowsFormsApp1.Business
{
    public class GridBusiness
    {
        #region Tile Movement
        public static void GoUp(Grid grid)
        {
            foreach (var tile in grid.GameGrid)
            {
                if (tile.YPosition == 0) continue;
                var tileAbove = grid.GetTile(tile.XPosition, tile.YPosition - 1);

                while (IsTileAvailable(tileAbove))
                {
                    TileBusiness.DoFusionTile(tileAbove, tile);
                }
            }
        }

        public static void GoDown(Grid grid)
        {
            foreach (var tile in grid.GameGrid)
            {
                if (tile.YPosition == Grid.MAX_HEIGHT - 1) continue; // Based on a 4x4 grid
                var tileBelow = grid.GetTile(tile.XPosition, tile.YPosition + 1);

                while (IsTileAvailable(tileBelow))
                {
                    TileBusiness.DoFusionTile(tileBelow, tile);
                }
            }
        }

        public static void GoLeft(Grid grid)
        {
            foreach (var tile in grid.GameGrid)
            {
                if (tile.XPosition == 0) continue;
                var tileLeft = grid.GetTile(tile.XPosition - 1, tile.YPosition);

                while (IsTileAvailable(tileLeft))
                {
                    TileBusiness.DoFusionTile(tileLeft, tile);
                }
            }
        }

        public static void GoRight(Grid grid)
        {
            foreach (var tile in grid.GameGrid)
            {
                if (tile.XPosition == Grid.MAX_WIDTH - 1) continue; // Based on a 4x4 grid
                var tileAbove = grid.GetTile(tile.XPosition + 1, tile.YPosition);

                while (IsTileAvailable(tileAbove))
                {
                    TileBusiness.DoFusionTile(tileAbove, tile);
                }
            }
        }
        #endregion

        public static bool IsTileAvailable(Tile tile)
        {
            return tile.Value != 0;
        }
    }
}
