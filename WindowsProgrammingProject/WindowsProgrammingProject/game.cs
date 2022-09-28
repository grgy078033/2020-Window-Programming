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
using MODE;

namespace WindowsProgrammingProject
{
    public partial class game : Form
    {
        Panel Panel1;
        //------------------------------------------------
        public int Rows = 15;
        public int size = 560;//修改棋盤
        public int slant = 50;
        //------------------------------------------------

        int[,] board = new int[15, 15];

        bool gameover = false;
        bool turn = true;//t=b f=w
        int mode = 1;

        public GFX PicEngine;
        public game()
        {
            InitializeComponent();
        }

        private void game_Load(object sender, EventArgs e)
        {
            //設定Form1
            this.Size = new Size(680, 700);

            //生成Panel
            Panel1 = new Panel();
            Panel1.Location = new Point(0, 0);
            Panel1.Size = this.Size;
            Panel1.BorderStyle = BorderStyle.None;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = Color.FromArgb(213, 179, 142);//SandyBrown,213,176,146
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.Panel1.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
            this.Controls.Add(Panel1);
            this.Text = "F2=P2C、F3=P2P、F5=Refresh";
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)//設定
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    if (MessageBox.Show("Player VS AI", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Panel1.Refresh();
                        mode = 1;
                    }
                    break;
                case Keys.F3:
                    if (MessageBox.Show("Player VS Player", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Panel1.Refresh();
                        mode = 0;
                    }
                    break;
                case Keys.F5:
                    Panel1.Refresh();
                    break;
            }
        }
        private void panel1_Paint(object sender, EventArgs e)//使用panel1.Refresh()來觸發
        {
            gameover = false;
            turn = true;
            board = new int[15, 15];
            Graphics pg = Panel1.CreateGraphics();
            PicEngine = new GFX(pg, Rows, size, slant);
        }

        private void panel1_MouseDown(object sender, EventArgs e)//下棋
        {
            Point mouse = Cursor.Position;
            mouse = Panel1.PointToClient(mouse);
            if (mouse.X < slant - GFX.gap / 2 || mouse.X > size + slant + GFX.gap / 2 ||
                mouse.Y < slant - GFX.gap / 2 || mouse.Y > size + slant + GFX.gap / 2) { return; }//是否出界

            Game(location(mouse));

            if (mode == 1)
            {
                Game(AI1(board));
            }
            //MessageBox.Show(mouse.ToString()+"\r\n"+location(mouse).ToString());
        }

        private void Game(Point P)
        {
            if (gameover) { return; }
            if (board[P.X, P.Y] != 0) { return; }
            if (turn)
            {
                PicEngine.drawB(P);
                board[P.X, P.Y] = 1;
            }
            else
            {
                PicEngine.drawW(P);
                board[P.X, P.Y] = 2;
            }
            if (cheakwin(P))
            {
                if (turn)
                    MessageBox.Show("B,WIN");
                else
                    MessageBox.Show("W,WIN");
                gameover = true;
            }
            turn = !turn;
        }

        private void C2C()
        {
            do
            {
                //黑先白後
                Game(AI1(board));
                Thread.Sleep(500);
            } while (!gameover);//gameover為bool
        }
        //AI1為預設對戰AI
        HsuAI HAI = new HsuAI();
        private Point AI1(int[,] B)//格式[橫,直] 0=空 1=黑 2=白
        {
            int[,] old = B;
            HAI.board = B;//匯入當前棋盤
            HAI.computer();
            return new Point(HAI.loc.X, HAI.loc.Y);
        }
        private bool cheakwin(Point P)
        {
            int t;
            if (turn) t = 1;
            else t = 2;

            int count = 0;
            for (int k = 0; k < 4; k++)
            {
                count = 0;
                for (int i = -4; i < 5; i++)
                {
                    switch (k)
                    {
                        case 0:// / 上斜
                            int sx = P.X - i; int sy = P.Y + i;
                            if (sx < 0 || sx > 14 || sy < 0 || sy > 14) continue;
                            if (board[sx, sy] == t) count++;
                            else count = 0;
                            break;
                        case 1:// \ 下斜
                            int s1 = P.X + i;
                            int s2 = P.Y + i;
                            if (s1 < 0 || s1 > 14 || s2 < 0 || s2 > 14) continue;
                            if (board[s1, s2] == t) count++;
                            else count = 0;
                            break;
                        case 2:// - 水平
                            int x = P.X + i;
                            if (x < 0 || x > 14) continue;
                            if (board[x, P.Y] == t) count++;
                            else count = 0;
                            break;
                        case 3:// | 垂直
                            int y = P.Y + i;
                            if (y < 0 || y > 14) continue;
                            if (board[P.X, y] == t) count++;
                            else count = 0;
                            break;
                    }
                    if (count == 5) return true;
                }
            }
            return false;
        }
        private Point location(Point loc)
        {
            int x = 0; int y = 0;
            int xp = 0; int yp = 0;
            int gap = GFX.gap;

            for (int i = 0; i < Rows; i++)
            {
                if ((i * gap - gap / 2) + slant - 1 < loc.X && loc.X < (i * gap + gap / 2) + slant)
                {
                    x = i;
                    xp = i * gap;
                }
                if ((i * gap - gap / 2) + slant - 1 < loc.Y && loc.Y < (i * gap + gap / 2) + slant)
                {
                    y = i;
                    yp = i * gap;
                }
            }
            return new Point(x, y);
        }
    }
}
