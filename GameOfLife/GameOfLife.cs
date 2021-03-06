﻿using System;
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
        public bool disFlag = false;
        Thread thdDisplay;
        Graphics gra;
        int delayTime = 1;
        int PBX_SIZE = 550;
        int INIT_POS = 0;


        public GameOfLife()
        {
            InitializeComponent();
            cellStatus = new int[10, 10];
            initArray();
            gra = this.pbx_stat.CreateGraphics();
            showStatus();
            Control.CheckForIllegalCrossThreadCalls = false;
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
            int tmpRow = cellStatus.GetLength(0);
            int tmpCol = cellStatus.GetLength(1);
            int diameter = 0;
            float offset = 0.0f;
            getPaintParam(ref diameter, ref offset);
            for (int i = 0; i < tmpRow; i++)
            {
                for (int j = 0; j < tmpCol; j++)
                {
                    if (cellStatus[i, j] == 1)
                    {
                        Brush brush = new SolidBrush(Color.Pink);
                        gra.FillEllipse(brush, INIT_POS + offset + i * diameter, INIT_POS + offset + j * diameter, diameter, diameter);
                    }
                    else
                    {
                        Brush brush = new SolidBrush(Color.White);
                        gra.FillEllipse(brush, INIT_POS + offset + i * diameter, INIT_POS + offset + j * diameter, diameter, diameter);
                    }

                }

            }

        }


        public void btn_start_Click(object sender, EventArgs e)
        {

            //Pen pen = new Pen(Color.Pink);
            if (btn_start.Text == "Start")
            {
                btn_start.Text = "Stop";
                disFlag = true;
                thdDisplay = new Thread(displayCell);
                thdDisplay.Start();
            }
            else
            {
                btn_start.Text = "Start";
                if ((thdDisplay != null) && (thdDisplay.IsAlive))
                {
                    disFlag = false;
                    thdDisplay.Join();
                }

            }


        }

        public void displayCell()
        {
            while (disFlag)
            {
                Thread.Sleep(delayTime);
                getStatus();
                showStatus();
            }
        }

        private void GameOfLife_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((thdDisplay != null) && (thdDisplay.IsAlive))
            {
                disFlag = false;
                thdDisplay.Join();
            }
        }

        private void txt_tm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_tm.Text != "")
                {
                    int tmpValue = Convert.ToInt32(txt_tm.Text);
                    if (tmpValue >= 0)
                    {
                        delayTime = tmpValue;
                    }
                }
            }
        }

        private void pbx_stat_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point pt = e.Location;
                int diameter = 0;
                float offset = 0.0f;
                getPaintParam(ref diameter, ref offset);

                if ((pt.X >= INIT_POS+offset) && (pt.Y >= INIT_POS+offset)&&(pt.X<=PBX_SIZE-INIT_POS-offset)&&(pt.Y<= PBX_SIZE - INIT_POS - offset))
                {
                    int XIndex = (int)Math.Floor((pt.X - INIT_POS-offset) / diameter);
                    int YIndex = (int)Math.Floor((pt.Y - INIT_POS - offset) / diameter);
                    cellStatus[XIndex, YIndex] = Math.Abs(cellStatus[XIndex, YIndex] - 1);

                }
                showStatus();

            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            if ((thdDisplay != null) && (thdDisplay.IsAlive))
            {
                disFlag = false;
                thdDisplay.Join();
            }

            btn_start.Text = "Start";
            int tmpRow = cellStatus.GetLength(0);
            int tmpCol = cellStatus.GetLength(1);
            for (int i = 0; i < tmpRow; i++)
            {
                for (int j = 0; j < tmpCol; j++)
                {
                    cellStatus[i, j] = 0;
                }
            }
            showStatus();
        }

        private void txt_num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_num.Text != "")
                {
                    int tmpValue = Convert.ToInt32(txt_num.Text);
                    if (tmpValue > 0)
                    {
                        cellStatus = new int[tmpValue, tmpValue];
                        initArray();
                        gra.Clear(pbx_stat.BackColor);
                        Thread.Sleep(100);
                        showStatus();

                    }
                }
            }
        }
        public void getPaintParam(ref int diameter,ref float offset)
        {
            int tmpRow = cellStatus.GetLength(0);
            diameter = PBX_SIZE / tmpRow;
            offset = (PBX_SIZE % tmpRow) / 2.0f;

        }
    }
}
