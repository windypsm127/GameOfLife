using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GameOfLife
{
    public partial class GameOfLife : Form
    {
        public int[,] cellStatus;
        public bool flag = false;

        public GameOfLife()
        {
            InitializeComponent();
            cellStatus = new int[10, 10];
            initArray();
            showStatus();
        }

        public void initArray()
        {
            Random rd = new Random();
            int tmpRow = cellStatus.GetLength(0);
            int tmpCol = cellStatus.GetLength(1);
            for (int i = 0; i < tmpRow; i++)
            {
                for (int j = 0; j < tmpCol; j++)
                {
                    cellStatus[i, j] = rd.Next(0, 2);
                }
            }

        }
        public void getStatus()

        {
            int tmpRow = cellStatus.GetLength(0);
            int tmpCol = cellStatus.GetLength(1);
            int[,] tmpValue = new int[tmpRow, tmpCol];
            for (int i = 0; i < tmpRow; i++)
            {
                for (int j = 0; j < tmpCol; j++)
                {
                    int tmpSum = getCellNum(i, j);
                    if (tmpSum == 3)
                    {
                        tmpValue[i, j] = 1;
                    }
                    else if (tmpSum == 2)
                    {
                        tmpValue[i, j] = cellStatus[i, j];
                    }
                    else
                    {
                        tmpValue[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < tmpRow; i++)
            {
                for (int j = 0; j < tmpCol; j++)
                {
                    cellStatus[i, j] = tmpValue[i, j];
                }
            }




        }
        public int getCellNum(int xPos, int yPos)
        {
            int tmpRow = cellStatus.GetLength(0);
            int tmpCol = cellStatus.GetLength(1);
            int result = 0;
            int next_x = 0;
            int next_y = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {

                    next_x = xPos + i;
                    next_y = yPos + j;
                    if ((next_x >= 0) && (next_y >= 0) && (next_x < tmpRow) && (next_y < tmpCol))
                    {
                        result += cellStatus[next_x, next_y];

                    }

                }

            }
            return result - cellStatus[xPos, yPos];
        }

        public void showStatus()
        {
            string tmpStr = null;
            int tmpRow = cellStatus.GetLength(0);
            int tmpCol = cellStatus.GetLength(1);
            for (int i = 0; i < tmpRow; i++)
            {
                for (int j = 0; j < tmpCol; j++)
                {
                    tmpStr += cellStatus[i, j].ToString() + "  ";

                }
                tmpStr += "\n";
            }
            lbl_stat.Text = tmpStr;
        }


        public void btn_start_Click(object sender, EventArgs e)
        {


            Thread.Sleep(1000);
            getStatus();
            showStatus();

        }
    }
}
