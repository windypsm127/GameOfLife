using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Tests
{
    [TestClass()]
    public class GameOfLifeTests
    {

        [TestMethod()]
        public void shouldChangeStatusTest()
        {
            GameOfLife test = new GameOfLife();
            test.cellStatus = new int[3, 3] { { 0, 1, 1 }, { 1, 1, 0 }, { 1, 1, 1 } };
            int[,] expectCells = new int[3, 3] { { 1, 1, 1 }, { 0, 0, 0 }, { 1, 0, 1 } };
            test.getStatus();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(expectCells[i, j], test.cellStatus[i, j]);
                }
            }
        }


        [TestMethod()]
        public void shouldKeepStatusTest()
        {
            GameOfLife test = new GameOfLife();
            int [,]expectCells = new int[4, 4] { { 0, 0, 0, 0 }, { 0, 1, 1, 0 }, { 0, 1, 1, 0 }, { 0, 0, 0, 0 } };
            test.cellStatus = new int[4, 4] { { 0, 0, 0,0 }, { 0, 1,1, 0 }, { 0, 1, 1,0 },{0,0,0,0 } };

            test.getStatus();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(expectCells[i, j], test.cellStatus[i, j]);
                }
            }
        }



        [TestMethod()]
        public void shouldGetCellNumber()
        {

            GameOfLife test = new GameOfLife();
            test.cellStatus = new int[3, 3] { { 0, 1, 1 }, { 1, 1, 0 }, { 1, 1, 1 } };
            Assert.AreEqual(3, test.getCellNum(0, 0));
            Assert.AreEqual(4, test.getCellNum(1, 0));
            Assert.AreEqual(5, test.getCellNum(1, 2));
        }
    }
}

namespace GameOfLifeTests
{
    class GameOfLifeTests
    {
    }
}
