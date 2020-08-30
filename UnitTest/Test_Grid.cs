using NUnit.Framework;
using WindowsFormsApp1.ViewModel;

namespace UnitTest
{
    public class Test_Grid
    {
        Grid grid;

        [SetUp]
        public void Setup()
        {
            grid = new Grid(Grid.MAX_WIDTH, Grid.MAX_HEIGHT);
        }

        [Test]
        public void Grid_Init()
        {
            Assert.IsNotNull(grid);
            foreach(var tile in grid.GameGrid)
            {
                Assert.IsNotNull(tile);
            }
        }
    }
}